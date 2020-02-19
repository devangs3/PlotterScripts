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
//using MySql.Data.MySqlClient;

namespace Gamry2Chamber
{
    public partial class Form1 : Form
    {
        private Socket sender1;
        private byte[] bytes = new byte[1024];
        string dataFolderName = "";
        private MySqlConnection conn;

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

                    // sample T and RH
                    readTempBtn.PerformClick();
                    readRHBtn.PerformClick();

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
            try
            {
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes(":SOURCE:CLOOP1:PVALUE?");

                // Send the data through the socket.    
                int bytesSent = sender1.Send(msg);

                // Receive the response from the remote device.    
                int bytesRec = sender1.Receive(bytes);
                Console.WriteLine("Temperature Process Value = {0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // convert byte to string 
                String rxstring = Encoding.Default.GetString(bytes);
                if (rxstring.Length > 0)
                    tempText.Text = rxstring;

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

        // read RH%
        private void readRHBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes(":SOURCE:CLOOP2:PVALUE?");

                // Send the data through the socket.    
                int bytesSent = sender1.Send(msg);

                // Receive the response from the remote device.    
                int bytesRec = sender1.Receive(bytes);
                Console.WriteLine("RH Process Value = {0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // convert byte to string 
                String rxstring = Encoding.Default.GetString(bytes);
                if (rxstring.Length > 0)
                    rhText.Text = rxstring;

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
                var connString = "Server=" + linkField.Text +
                    " ;User ID=" + userField.Text + // "@%" +
                    ";Password=" + passField.Text +
                    ";Database=" + databaseField.Text +
                    ";Port=" + portSQLField.Text;

                using (conn = new MySqlConnection(connString))
                {
                    try
                    {
                        //await conn.OpenAsync();

                        conn.Open();

                        //// Insert some data
                        //using (var cmd = new MySqlCommand())
                        //{
                        //    cmd.Connection = conn;
                        //    cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
                        //    cmd.Parameters.AddWithValue("p", "Hello world");
                        //    await cmd.ExecuteNonQueryAsync();
                        //}

                        // Retrieve all rows
                        // method 1 
                        /*
                        using (var cmd = new MySqlCommand("SELECT * " +
                            "FROM bio_semi.test1 " +
                            "limit 0, 100;", conn))
                        using (var reader = await cmd.ExecuteReaderAsync())
                            while (await reader.ReadAsync())
                                Console.WriteLine(reader.GetString(0));
                        */

                        // method 2 
                        using (var cmd = new MySqlCommand("SELECT * " +
                            "FROM bio_semi.test1 " +
                            "limit 0, 100;", conn))
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

            // sample T and RH
            readTempBtn.PerformClick();
            readRHBtn.PerformClick();

            // check if T reached setpoint 
            int tempPt = Convert.ToInt32(tempText);
            int hiThreshold = Convert.ToInt32(HiPt.Value);
            int loThreshold = Convert.ToInt32(LoPt.Value);
            if (tempPt - loThreshold < 2 || hiThreshold - tempPt < 2)
            {
                // trigger measure 
                TriggerGamryScan();

                // cleanup and upload to SQL
                Upload2mySQL();

                // double backup; rename files 
                RenameLatestFiles();

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
                    MessageBoxButtons.OK, MessageBoxIcon.Error );

                // exit this function 
                return;
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
            
            // select data path folder ////////////////////////
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                dataFolderName = folderBrowserDialog1.SelectedPath;
                // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
            else
            {
                return;
            }

            // Change path in Gamry /////////////////////////////
            int hwnd = 0;
            IntPtr hwndChild = IntPtr.Zero;
            IntPtr hwndPtr = IntPtr.Zero;

            //Get a handle for the Calculator Application main window
            // hwnd=FindWindow(null, "C:\\Program Files(x86)\\Gamry Instruments\\Framework\\framework.exe");

            // get all open window names 
            Process[] processlist = Process.GetProcesses();
            String titleString = "";
            foreach (Process process in processlist)
            {
                // pick windows with titles 
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    // Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);

                    // pick gamry window title string as it changes with open file name 
                    if (process.MainWindowTitle.Contains("Gamry Instruments Framework"))
                    {
                        titleString = process.MainWindowTitle;
                        hwndPtr = process.MainWindowHandle;
                        break;
                    }
                }
            }


            hwnd = FindWindow(null, titleString);

            if (hwnd == 0 || titleString == "")
            {
                if (MessageBox.Show("Couldn't find Gamry Framework. Do you want to start it?", "TestWinAPI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("C:\\Program Files(x86)\\Gamry Instruments\\Framework\\framework.exe");
                }
            }
            else
            {
                // bool kkk = 
                SetForegroundWindow(hwndPtr);
                //open "configure path' dialog box from options menu 
                SendKeys.Send("%op");

                // wait for sequence wizard to open 
                Thread.Sleep(3000);

                // move to DTA in configure path dialog
                SendKeys.Send("{TAB}{TAB}");
                // set data folder path 
                SendKeys.Send(dataFolderName);
                // hit return key 
                SendKeys.Send("{ENTER}");

                // data path is now set and active
                dataPathBtn.BackColor = Color.Green;
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
            databaseField.Enabled = v;
            userField.Enabled = v;
            passField.Enabled = v;
            portSQLField.Enabled = v;
            connectSQLBtn.Enabled = v;

            moduleField.Enabled = v;
            batchField.Enabled = v;
            replicateField.Enabled = v;

            tcnField.Enabled = v;
            tsField.Enabled = v;
            LoPt.Enabled = v;
            HiPt.Enabled = v;
            // groupBox1.Enabled = v;
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
        private void RenameLatestFiles()
        {
            string timestampnow = Convert.ToString(getEpochTimeStamp());
            DirectoryInfo d = new DirectoryInfo(dataFolderName);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                // if (f.Name.Contains("EISPOT"))
                // rename files with name EISPOT_##.DTA
                // replace text EISPOT                
                File.Move(f.FullName, f.FullName.Replace("EISPOT", timestampnow + "_" +
                    moduleField.Text + "_" + 
                    batchField.Text + "_" +
                    replicateField.Text + "_" +
                    Convert.ToString(tcnField.Value) 
                    ));                    
            }
        }

        private void Upload2mySQL()
        {
            // select files named EISPOT_##.DTA only             
            DirectoryInfo d = new DirectoryInfo(dataFolderName);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                if (f.Name.Contains("EISPOT"))
                {
                    // read file 


                    // append to table 
                }   
            }

            // clean up and add columns 



            // upload 
            try
            {
                //await conn.OpenAsync();
                // conn.Open();

                // Insert some data
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
                    cmd.Parameters.AddWithValue("p", "Hello world");
                    // await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void TriggerGamryScan()
        {
            int hwnd = 0;
            IntPtr hwndChild = IntPtr.Zero;
            IntPtr hwndPtr = IntPtr.Zero;

            //Get a handle for the Calculator Application main window
            // hwnd=FindWindow(null, "C:\\Program Files(x86)\\Gamry Instruments\\Framework\\framework.exe");

            // get all open window names 
            Process[] processlist = Process.GetProcesses();
            String titleString = "";
            foreach (Process process in processlist)
            {
                // pick windows with titles 
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    // Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);

                    // pick gamry window title string as it changes with open file name 
                    if (process.MainWindowTitle.Contains("Gamry Instruments Framework"))
                    {
                        titleString = process.MainWindowTitle;
                        hwndPtr = process.MainWindowHandle;
                        break;
                    }
                }
            }


            hwnd = FindWindow(null, titleString);

            if (hwnd == 0 || titleString == "")
            {
                if (MessageBox.Show("Couldn't find the application. Do you want to start it?", "TestWinAPI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("C:\\Program Files(x86)\\Gamry Instruments\\Framework\\framework.exe");
                }
            }
            else
            {                
                // bool kkk = 
                SetForegroundWindow(hwndPtr);
                //send "sequence wizard" dialog from Experiment menu
                SendKeys.Send("%xw");

                // wait for sequence wizard to open 
                Thread.Sleep(3000);

                // search process handle for "sequence wizard" dialog 
                Process[] p = Process.GetProcessesByName("Sequencer");
                if (p[0] != null)
                {
                    IntPtr h = p[0].MainWindowHandle;
                    SetForegroundWindow(h);
                    // send alt, R to run sequence in dialog
                    SendKeys.Send("%");
                    SendKeys.Send("r");
                }
            }
        }

            private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // got to TI website 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // go to UTD website 
        }
    }
}
