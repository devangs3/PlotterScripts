using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using IniParser;
using IniParser.Model;
using Z.Expressions;
using System.Reflection;
// using MySql.Data.MySqlClient;
// using IniParser;
// using IniParser.Model;

namespace Gamry2Chamber
{
    public partial class Form1 : Form
    {
        private Socket sender1;
        private byte[] bytes = new byte[1024];
        string dataFolderName = "";
        private MySqlConnection conn;
        string connString = "";

        string frameworkPath = "C:\\Program Files (x86)\\Gamry Instruments\\Framework\\framework.exe";
        string scriptsPath = "C:\\ProgramData\\Gamry Instruments\\Framework\\Scripts\\";
        string iniPath = "C:\\ProgramData\\Gamry Instruments\\Framework\\UTDallas.INI";
        System.Diagnostics.Process process = new System.Diagnostics.Process();

        // define class object for uploading a data column format to multiple tables in mySQL
        class dataBlock {
            internal string tableSuffix { get; set; }
            internal string scriptName { get; set; }
            internal string[] columnNames { get; set; }
            internal string[] inputHandles { get; set; }
            internal string printString { get; set; }
            internal string columnNameSQL { get { return string.Join(",", this.columnNames); } }
            // contructors 
            public dataBlock() { }
            public dataBlock(string input1, string[] input2, string[] input3, string input4, string input5)
            {
                tableSuffix = input1;
                columnNames = input2;
                inputHandles = input3;
                printString = input4;
                scriptName = input5;
            }
        }

        dataBlock healthBlock = new dataBlock("health",
            new string[] {"operator", "timestamp", "TSP", "TPV", "RHSP", "RHPV"} ,
            new string[] { "userField", "", "tspText", "tpvText", "rhspText", "rhpvText" },
             "('{0}',{1},{2},{3},{4},{5})",
            "");
        dataBlock scanBlock = new dataBlock("scan",
            new string[] { "operator","module","batch","replicate","TCN","run","TSP","RHSP","timestamp",
                "TPV","RHPV","frequency","Zmod","Zphase","Zreal","Zimag" },
            new string[] { "userField", "moduleField", "batchField", "replicateField", "TCN", "", "tspText",  "rhspText","",
                "tpvText", "rhpvText","","","","","" },
            "('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})",
            "scangamry.exp");

        dataBlock contBlock = new dataBlock("continuous",
            new string[] { "operator","module","batch","replicate","run","TSP","RHSP","timestamp",
                "TPV","RHPV","frequency","Zmod","Zphase","Zreal","Zimag" },
            new string[] { "userField", "moduleField", "batchField", "replicateField", "", "tspText",  "rhspText","",
                 "tpvText", "rhpvText","","","","","" },
            "('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})",
            "contgamry.exp");

        // DLL inserts for controlling Gamry Framework ////////////////
        /// <summary>
        /// The FindWindow API
        /// </summary>
        /// <param name="lpClassName">the class name for the window to search for</param>
        /// <param name="lpWindowName">the name of the window to search for</param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        /// <summary>
        /// The SendMessage API
        /// </summary>
        /// <param name="hWnd">handle to the required window</param>
        /// <param name="msg">the system/Custom message to send</param>
        /// <param name="wParam">first message parameter</param>
        /// <param name="lParam">second message parameter</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(int hWnd, int msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// The FindWindowEx API
        /// </summary>
        /// <param name="parentHandle">a handle to the parent window </param>
        /// <param name="childAfter">a handle to the child window to start search after</param>
        /// <param name="className">the class name for the window to search for</param>
        /// <param name="windowTitle">the name of the window to search for</param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // connect to F4T device on the chamber 
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to a Remote server  
                // Get Host IP Address that is used to establish a connection  
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                // If a host has multiple addresses, you will get a list of addresses  
                // IPHostEntry host = Dns.GetHostEntry(ipField.Text);
                // IPAddress ipAddress = host.AddressList[0];
                IPAddress ipAddress = IPAddress.Parse(ipField.Text);
                int portNum = Convert.ToInt16(portChamberField.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, portNum);

                // Create a TCP/IP  socket.    
                sender1 = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    sender1.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender1.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.    
                    byte[] msg = Encoding.ASCII.GetBytes("*idn?");

                    // Send the data through the socket.    
                    int bytesSent = sender1.Send(msg);

                    // Receive the response from the remote device.    
                    int bytesRec = sender1.Receive(bytes);

                    Console.WriteLine(" chamber ID = {0}",
                         Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // check connectivity
                    if (connectChamberBtn.BackColor == Color.Green)
                    {
                        // Release the socket.    
                        sender1.Shutdown(SocketShutdown.Both);
                        sender1.Close();
                    }
                    else
                    {
                        // convert byte to string 
                        String rxstring = Encoding.Default.GetString(bytes);
                        if (rxstring.Contains("F4T"))
                        {
                            // active link
                            connectChamberBtn.BackColor = Color.Green;
                            // switch to next tab  
                            tabControl1.SelectedIndex += 1;
                        }
                    }

                    // clear byte buffer after use  
                    Array.Clear(bytes, 0, bytes.Length);

                    // sample T and RH PV and SP 
                    readTpvBtn.PerformClick();
                    readRhpvBtn.PerformClick();
                    readTspBtn.PerformClick();
                    readRhspBtn.PerformClick();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception ee)
                {
                    Console.WriteLine("Unexpected exception : {0}", ee.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // read temperature
        private void readTempBtn_Click(object sender, EventArgs e)
        {
            // send command to chamber
            // refer to F4T programming resources for commands 
            sendSocketComm(":SOURCE:CLOOP1:PVALUE?", ref tpvText);
        }

        // read RH%
        private void readRHBtn_Click(object sender, EventArgs e)
        {
            // send command to chamber
            // refer to F4T programming resources for commands 
            sendSocketComm(":SOURCE:CLOOP2:PVALUE?", ref rhpvText);
        }
        
        private void readTspBtn_Click(object sender, EventArgs e)
        {
            // send command to chamber
            // refer to F4T programming resources for commands 
            sendSocketComm(":SOURCE:CLOOP1:SPOINT?", ref tspText);
        }

        private void readRhspBtn_Click(object sender, EventArgs e)
        {
            // send command to chamber
            // refer to F4T programming resources for commands 
            sendSocketComm(":SOURCE:CLOOP2:SPOINT?", ref rhspText);
        }

        private void LoPt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Assign the asterisk to be the password character.
            passField.PasswordChar = '*';
            // Link tool tips
            toolTipGamry.SetToolTip(this.dataPathBtn, "This modifies the Gamry Framework settings!");
            toolTipGamry.SetToolTip(this.startBtn, "This modifies the Gamry Framework settings!");
            // resize by anchoring 
            // Anchor the button to the bottom right corner of the form
            // tabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
            // tabControl1.AutoSize = true;
        }

        private void HighPt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60000 * Convert.ToInt32(tsField.Value);
        }

        private async void connectSQLBtn_Click(object sender, EventArgs e)
        {
            // string to get all records columns appended
            StringBuilder sb = new StringBuilder();

            if (connectSQLBtn.BackColor == Color.Green)
            {
                // close connection 
                conn.Close();
            }
            else
            {
                // connect to mySQL server
                // source = https://mysqlconnector.net/tutorials/basic-api/
                connString = "Server=" + linkField.Text +
                    " ;User ID=" + userField.Text + // "@%" +
                    ";Password=" + passField.Text +
                    ";Database=" + schemaField.Text + //scanBlock.tableSuffix +
                    ";Port=" + portSQLField.Text;

                using (conn = new MySqlConnection(connString))
                {
                    try
                    {
                        // open database connection 
                        conn.Open();

                        // test query
                        using (var cmd = new MySqlCommand("SELECT * " +
                            "FROM " +
                            schemaField.Text + "." +
                            tableField.Text + scanBlock.tableSuffix  +
                            " limit 0, 10;", conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    if (sb.Length > 0) sb.Append("___");
                                    while (reader.Read())
                                    {
                                        for (int i = 0; i < reader.FieldCount; i++)
                                            if (reader.GetValue(i) != DBNull.Value)
                                                sb.AppendFormat("{0},", Convert.ToString(reader.GetValue(i)));
                                        sb.Append("\r\n");
                                    }
                                }
                            }

                        }
                        // check received data from connection test 
                        Console.WriteLine(sb);

                        // connection is green 
                        connectSQLBtn.BackColor = Color.Green;

                        // switch to next tab
                        tabControl1.SelectedIndex += 1;

                        // close connection
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
            }
        }

        // all actions happen here !!!!!!
        private void timer1_Tick(object sender, EventArgs e)
        {
            // pause timer 
            timer1.Enabled = false;

            // sample T and RH, PV and SP
            readTpvBtn.PerformClick();
            readRhpvBtn.PerformClick();
            readTspBtn.PerformClick();
            readRhspBtn.PerformClick();

            // upload chamber data to health table 
            Upload2mySQL("", healthBlock);

            // check if T reached setpoint 
            double tempPt = Math.Round(Convert.ToDouble(tpvText.Text));
            int hiThreshold = Convert.ToInt32(HiPt.Value);
            int loThreshold = Convert.ToInt32(LoPt.Value);
            // process for half cycle, one setpoint and one ramp 
            if (tempPt - loThreshold < 1 || hiThreshold - tempPt < 1)
            {
                // if SF_EIS running, stop it and do necessary steps
                if(radioLevelEdge.Checked)
                {
                    // kill process, no need to check flag
                    process.Kill();

                    // cleanup and upload to SQL
                    Upload2mySQL("EISMON", contBlock);

                    // double backup; rename files 
                    RenameLatestFiles("EISMON");                                       
                }

                // trigger measure 
                TriggerGamry(scanBlock.scriptName);                 

                // cleanup and upload to SQL
                Upload2mySQL("EISPOT", scanBlock);
                // Upload2mySQL("EISMON", contBlock);

                // double backup; rename files 
                RenameLatestFiles("EISPOT");
                // RenameLatestFiles("EISMON");

                //increment TCN 
                tcnField.Text = Convert.ToString(Convert.ToDouble(tcnField.Text) + 0.5);
                
                // reset INI flag 
                writeINI(iniPath, "FLAGSECTION", "FLAG1", "READY");

                // write new setpoint 
                string newTSP = "";
                // !!! change setpoint based on previous setpoint 
                if (tspText.Text == Convert.ToString(LoPt.Value))
                { newTSP = Convert.ToString(HiPt.Value); }
                else 
                { newTSP = Convert.ToString(LoPt.Value); }
                sendSocketComm(":SOURCE:CLOOP1:SPOINT"+newTSP);

                // start EIS monitor if level+edge mode
                if (radioLevelEdge.Checked){
                    // start continuos EIS mode 
                    TriggerGamry(contBlock.scriptName);
                }

            }
            // end of process, restart timer 
            timer1.Enabled = true;
            timer1.Start();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            // check chamber and cloud connection 
            if (connectChamberBtn.BackColor != Color.Green || connectSQLBtn.BackColor != Color.Green)
            {
                // show error 
                MessageBox.Show("Check chamber and cloud connectivity", "Connectivity error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // exit this function 
                return;
            }

            // check data path is synced with Gamry 
            if (dataPathBtn.BackColor != Color.Green)
            {
                // show error 
                MessageBox.Show("Check Gamry is active and path is synced using the data path button", "Gamry sync error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // exit this function 
                return;
            }

            // check if chamber power is on and controller is active 
            // show error 
            MessageBox.Show("Check chamber is powered on and conditioning switch is ON", "Check chamber switches",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // send high setpoint to chamber to start first
            // no profile needed on chamber controller ! :) 
            sendSocketComm(":SOURCE:CLOOP1:SPOINT " + Convert.ToString(HiPt.Value));            

            // start continuous EIS if selected
            if (radioLevelEdge.Checked){
                TriggerGamry(contBlock.scriptName);
            }


            // turn button green
            startBtn.BackColor = Color.Green;
            startBtn.ForeColor = Color.White;

            // grey out process parameters, these should not edit during a run 
            enableAll(false);

            // enable timer 
            timer1.Enabled = true;
            timer1.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            // cancel grey out process parameters
            enableAll(true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void toolTipDataPath_Popup(object sender, PopupEventArgs e)
        {

        }

        // sets data path in Gamry 
        private void pathBtn_Click(object sender, EventArgs e)
        {
            // select folder 
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                // change INI path 
                writeINI(iniPath, "GROUPING1", "NAME", folderBrowserDialog1.SelectedPath);
                // data path is now set and active
                dataPathBtn.BackColor = Color.Green;
                dataPathBtn.ForeColor = Color.White;
            }
            else
            {
                // data path is now set and active
                dataPathBtn.BackColor = Color.Red;
                dataPathBtn.ForeColor = Color.White;
            }
        }

        // helper functions ////////////////////////////////////////////////////
        private void enableAll(bool v)
        {
            ipField.Enabled = v;
            subnetField.Enabled = v;
            portChamberField.Enabled = v;
            connectChamberBtn.Enabled = v;

            linkField.Enabled = v;
            schemaField.Enabled = v;
            userField.Enabled = v;
            passField.Enabled = v;
            portSQLField.Enabled = v;
            connectSQLBtn.Enabled = v;
            tableField.Enabled = v;

            moduleField.Enabled = v;
            batchField.Enabled = v;
            replicateField.Enabled = v;

            tcnField.Enabled = v;
            tsField.Enabled = v;
            LoPt.Enabled = v;
            HiPt.Enabled = v;
            groupBox1.Enabled = v;
        }
        private int getEpochTimeStamp()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            Console.WriteLine(secondsSinceEpoch);
            return secondsSinceEpoch;
        }

        private string getBMNLTimeStamp()
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
            return dy + mn + yy;
        }
        private void RenameLatestFiles(string file2look)
        {
            string timestampnow = Convert.ToString(getEpochTimeStamp());
            DirectoryInfo d = new DirectoryInfo(dataFolderName);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                if (f.Name.Contains(file2look))
                // rename files with name specified
                // replace text file2look with custom                
                File.Move(f.FullName, f.FullName.Replace(file2look, timestampnow + "_" +
                    moduleField.Text + "_" +
                    batchField.Text + "_" +
                    replicateField.Text + "_" +
                    Convert.ToString(tcnField.Value)
                    ));
            }
        }

        private void Upload2mySQL(string file2look, dataBlock settings)
        {
            // select files named EISPOT_##.DTA only  
            string timeZero="";
            DataTable table = new DataTable();
            // if data is not for not health table; i.e. actual sample data 
            if (file2look != "")
            {
                DirectoryInfo d = new DirectoryInfo(dataFolderName);
                FileInfo[] infos = d.GetFiles();
                table.Columns.Add("frequency", typeof(string));
                table.Columns.Add("Zmod", typeof(string));
                table.Columns.Add("Zphase", typeof(string));
                table.Columns.Add("Zreal", typeof(string));
                table.Columns.Add("Zimag", typeof(string));
                if (file2look == "EISPOT")
                {
                    table.Columns.Add("run", typeof(string));
                }
                if (file2look == "EISMON")
                {
                    table.Columns.Add("timestamp", typeof(string));
                }

                foreach (FileInfo f in infos)
                {
                    if (f.Name.Contains(file2look))
                    {
                        // read file
                        string[] lines = File.ReadAllLines(f.FullName);

                        // get date time of script run ///////////////////////
                        string dateline = lines[3]; // line 4
                        string timeline = lines[4]; // line 5 
                                                    // convert to epoch, use this to save timestamp
                        dateline = dateline.Split('\t')[2]; // 3rd word
                        timeline = timeline.Split('\t')[2]; // 3rd word
                        DateTimeOffset dto = new DateTimeOffset(Convert.ToInt32(dateline.Split('/')[2]), // year 
                            Convert.ToInt32(dateline.Split('/')[0]), // month
                            Convert.ToInt32(dateline.Split('/')[1]), // date
                            Convert.ToInt32(timeline.Split(':')[0]), // hr24 
                            Convert.ToInt32(timeline.Split(':')[1]), // min 
                            Convert.ToInt32(timeline.Split(':')[2]), // sec
                            TimeSpan.Zero);
                        timeZero = dto.ToUnixTimeSeconds().ToString();

                        // remove header lines
                        lines = lines.Skip(57).ToArray();

                        // read into file 
                        foreach (string line in lines)
                        {
                            // split by space
                            string[] col = line.Split('\t');

                            // append to table
                            DataRow row = table.NewRow();
                            if (col.Length > 10) // assuming 11 or 12 columns
                            {
                                row.SetField("frequency", col[3]);
                                row.SetField("Zmod", col[7]);
                                row.SetField("Zphase", col[8]);
                                row.SetField("Zreal", col[4]);
                                row.SetField("Zimag", col[5]);

                                // remove unnecesary columns and clean up 
                                if (file2look == "EISPOT")
                                {
                                    char[] index = { f.Name[8] };
                                    row.SetField("run", new string(index)); // EISPOT_#N.DTA

                                }
                                if (file2look == "EISMON")
                                {
                                    row.SetField("timestamp", timeZero + col[1]); // column 2 of SF-EIS file                                 
                                }
                            }
                            table.Rows.Add(row);
                        }
                    }
                }

                // add columns intialized with the a fixed value //////////////////
                for (int i = 0; i < settings.columnNames.Length; i++)
                {
                    if (settings.inputHandles[i] != "")
                        addColumnFixed<string>(table, settings.columnNames[i], settings.inputHandles[i] + ".Text");
                }

                //if (file2look == "EISPOT")
                //{
                //    addColumnFixed<string>(table, "module", moduleField.Text);
                //    addColumnFixed<string>(table, "batch", batchField.Text);
                //    addColumnFixed<string>(table, "replicate", replicateField.Text);
                //    addColumnFixed<string>(table, "TCN", tcnField.Text);
                //    addColumnFixed<string>(table, "timestamp", timeZero);
                //    addColumnFixed<string>(table, "RHSP", rhspText.Text);
                //    addColumnFixed<string>(table, "RHPV", rhpvText.Text);
                //    addColumnFixed<string>(table, "TSP", tspText.Text);
                //    addColumnFixed<string>(table, "TPV", tpvText.Text);
                //    addColumnFixed<string>(table, "operator", userField.Text);
                //}
                //if (file2look == "EISMON")
                //{
                //    addColumnFixed<string>(table, "module", moduleField.Text);
                //    addColumnFixed<string>(table, "batch", batchField.Text);
                //    addColumnFixed<string>(table, "replicate", replicateField.Text);
                //    // addColumnFixed<string>(table, "TCN", tcnField.Text);
                //    // addColumnFixed<string>(table, "timestamp", getEpochTimeStamp().ToString());
                //    addColumnFixed<string>(table, "RHSP", rhspText.Text);
                //    addColumnFixed<string>(table, "RHPV", rhpvText.Text);
                //    addColumnFixed<string>(table, "TSP", tspText.Text);
                //    addColumnFixed<string>(table, "TPV", tpvText.Text);
                //    addColumnFixed<string>(table, "operator", userField.Text);
                //}


                //double tempPt = Convert.ToDouble(tpvText.Text);
                //int hiThreshold = Convert.ToInt32(HiPt.Value);
                //int loThreshold = Convert.ToInt32(LoPt.Value);
                //if (tempPt - loThreshold < 1)
                //    addColumnFixed<string>(table, "T", LoPt.Text);
                //else if (hiThreshold - tempPt < 1)
                //    addColumnFixed<string>(table, "T", HiPt.Text);
                //else
                //    addColumnFixed<string>(table, "T", "1.11");
            }
            // chamber health data 
            else if (file2look == "")
            {
                // add columns intialized with the a fixed value from handles //////////////////
                for (int i = 0; i < settings.columnNames.Length; i++)
                {
                    if (settings.inputHandles[i] != "")
                    {
                        // Type t = Type.GetType(settings.inputHandles[i]); // get type of object whose handle name is stored 
                        // PropertyInfo p = t.GetProperty("Text"); // get text property for that object 
                        //addColumnFixed<string>(table, settings.columnNames[i], p.GetValue(null,null).ToString());

                        // use eval statement , not working 
                        var nameGetter = Eval.Compile<Func<dataBlock, string>>("x.Text","x");
                        var name = nameGetter();
                        addColumnFixed<string>(table, settings.columnNames[i], name.ToString());
                    }
                }
                // define non-handle controlled column
                addColumnFixed<string>(table, "timestamp", getEpochTimeStamp().ToString());

                // insert only one record, default values will be initialized automatically ! :)
                // this is for mySQL upload script usability
                DataRow row = table.NewRow();
                table.Rows.Add(row);
            }
            // dataBlock format did not match, throw exception
            else 
            {
                throw new System.ArgumentException("No matching datablock found for mySQL upload!");
            }

            // upload to server
            try
            {
                // bulk upload using string building feature
                StringBuilder sCommand = new StringBuilder("INSERT INTO " +
                    tableField.Text + settings.tableSuffix +
                    "(" + 
                    settings.columnNameSQL +
                    // "module, batch, replicate, TCN, run," +
                    // "timestamp, RHSP, RHPV, TSP, TPV, operator," +
                    // " frequency, Zmod, Zphase, Zreal, Zimag" +
                    ") VALUES ");
                List<string> Rows = new List<string>();
                DataRow[] rows = table.Select();
                for (int i = 0; i < rows.Length; i++)
                {
                    // create record escape string list 
                    List<object> record = new List<object>();
                    foreach( DataColumn column in table.Columns) {
                        record.Add(MySqlHelper.EscapeString(rows[i].Field<string>(column.ToString())));                
                    }
                    // add record data to a mySQL string list 
                    Rows.Add(string.Format(
                        settings.columnNameSQL,
                        //"('{0}','{1}','{2}',{3},{4},{5}," +
                        //"{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})",
                        record.ToArray()
                        //MySqlHelper.EscapeString(rows[i].Field<string>("module")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("batch")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("replicate")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("TCN")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("run")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("timestamp")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("RHSP")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("RHPV")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("TSP")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("TPV")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("operator")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("frequency")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("Zmod")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("Zphase")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("Zreal")),
                        //MySqlHelper.EscapeString(rows[i].Field<string>("Zimag"))
                    ));
                }
                // join list of strings and terminate mySQL command with ';'
                sCommand.Append(string.Join(",", Rows));
                sCommand.Append(";");
                // actual point of transmission 
                using (conn = new MySqlConnection(connString))
                {
                    // open database connection 
                    conn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand(sCommand.ToString(), conn))
                    {
                        myCmd.CommandType = CommandType.Text;
                        Console.WriteLine("Writing to database using query ...");
                        Console.WriteLine(sCommand.ToString());
                        int r = myCmd.ExecuteNonQuery();
                        Console.WriteLine("%d rows written! ", r);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void addColumnFixed<T>(DataTable table, string columnName, T value)
        {
            System.Data.DataColumn newColumn = new System.Data.DataColumn(columnName, typeof(T));
            newColumn.DefaultValue = value; 
            table.Columns.Add(newColumn);
        }

        private void TriggerGamry(string scanScript)
        {
            send2cmd(frameworkPath + " " + scriptsPath + scanScript);            
            // check for flag1 == DONE from custom Gamry INI 
            string flagValue;
            do
            {
                // wait 
                Thread.Sleep(10000);
                // try flag read 
                flagValue = readINI(iniPath, "FLAGSECTION", "FLAG1");
            } while (flagValue != "DONE");
        }

        // run something on a hidden cmd window 
        private void send2cmd(string arguments)
        {            
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            // startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            startInfo.Arguments = arguments;
            process.StartInfo = startInfo;
            process.Start();
        }

        private string readINI(string filepath, string section, string varname)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filepath);
            return data[section][varname];
        }

        private void writeINI(string filepath, string section, string varname, string value)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filepath);
            data[section][varname] = value;
            parser.WriteFile(filepath, data);
        }

        // send and receive 
        private void sendSocketComm(string v, ref Label labelHandle)
        {
            try
            {
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes(v);

                // Send the data through the socket.    
                int bytesSent = sender1.Send(msg);

                // Receive the response from the remote device.    
                int bytesRec = sender1.Receive(bytes);
                Console.WriteLine("{0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // convert byte to string 
                String rxstring = Encoding.Default.GetString(bytes);
                if (rxstring.Length > 0)
                    labelHandle.Text = rxstring;

                // Release the socket.    
                // sender1.Shutdown(SocketShutdown.Both);
                // sender1.Close();

                // clear byte buffer after use 
                Array.Clear(bytes, 0, bytes.Length);

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine("Unexpected exception : {0}", ee.ToString());
            }

        }
        // only send 
        private void sendSocketComm(string v)
        {
            try
            {
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes(v);

                // Send the data through the socket.    
                int bytesSent = sender1.Send(msg);

                // Receive the response from the remote device.    
                int bytesRec = sender1.Receive(bytes);
                Console.WriteLine("{0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // convert byte to string 
                String rxstring = Encoding.Default.GetString(bytes);
                if (rxstring.Length > 0)
                { 
                    //labelHandle.Text = rxstring; 
                }

                // Release the socket.    
                // sender1.Shutdown(SocketShutdown.Both);
                // sender1.Close();

                // clear byte buffer after use 
                Array.Clear(bytes, 0, bytes.Length);

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine("Unexpected exception : {0}", ee.ToString());
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // got to TI website 
            System.Diagnostics.Process.Start("http://ti.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // go to UTD website 
            System.Diagnostics.Process.Start("http://utdallas.edu");
        }        

        private void label20_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            // find a control
            // Controls.Find("userField", true)[0].Text = "New text!";

            //setpoint change to normal 
            sendSocketComm(":SOURCE:CLOOP1:SPOINT 25");

        }

        private void rhpvText_Click(object sender, EventArgs e)
        {

        }

        private void tpvText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //    stopBtn.BackColor = Color.Green;
            //else
            //    stopBtn.BackColor = Color.OrangeRed;
        }
    }
}
