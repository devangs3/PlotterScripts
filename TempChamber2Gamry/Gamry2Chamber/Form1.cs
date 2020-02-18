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
//using MySql.Data.MySqlClient;

namespace Gamry2Chamber
{
    public partial class Form1 : Form
    {
        private Socket sender1;
        private byte[] bytes = new byte[1024];

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
                    Console.WriteLine("Echoed test = {0}",
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
                            connectChamberBtn.BackColor = Color.Green;
                    }                  

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
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // convert byte to string 
                    String rxstring = Encoding.Default.GetString(bytes);
                    if (rxstring.Length > 0)
                        tempText.Text = rxstring;

                    // Release the socket.    
                    sender1.Shutdown(SocketShutdown.Both);
                    sender1.Close();

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
                Console.WriteLine("Echoed test = {0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // convert byte to string 
                String rxstring = Encoding.Default.GetString(bytes);
                if (rxstring.Length > 0)
                    rhText.Text = rxstring;

                // Release the socket.    
                sender1.Shutdown(SocketShutdown.Both);
                sender1.Close();

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
        }

        private void HighPt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60000 * Convert.ToInt32(Ts.Value);
        }

        private async void connectSQLBtn_Click(object sender, EventArgs e)
        {
            if (connectSQLBtn.BackColor == Color.Green)
            {
                // disconnect

            }
            else
            {
                // connect to mySQL server
                // source = https://mysqlconnector.net/tutorials/basic-api/
                var connString = "Server=" + linkField.Text +
                    " ;User ID=" + userField.Text + // "@%" +
                    ";Password=" + passField.Text +
                    ";Database=" + "bio_semi" + 
                    ";Port=" + portSQLField.Text;

                using (var conn = new MySqlConnection(connString))
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
                            using (StringBuilder sb = new StringBuilder())
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
                                                    sb.AppendFormat("{0}-", Convert.ToString(reader.GetValue(i)));
                                        }
                                    }
                                }
                            }
                        }
                        // connection is green 
                        connectSQLBtn.BackColor = Color.Green;

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

            // sample T 

            // check if T reached setpoint 

            // trigger measure 

            // cleanup and upload to SQL

            // double backup; rename files 

            // end of process, restart timer 
            timer1.Enabled = true;
            timer1.Start();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
    
       
}
