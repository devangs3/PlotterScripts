using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


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
                int portNum = Convert.ToInt16(portField.Text);
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
                    if (connectBtn.BackColor == Color.Green)
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
                            connectBtn.BackColor = Color.Green;
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
    }
    
       
}
