using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace HTTPTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // when the user clicks send - we'll open a socket to the specified IP address
        // and on the specified port - then bundle up the message and send it off ...
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[8192];
            string strRequest, stringData;
            IPEndPoint ipep = new IPEndPoint( IPAddress.Parse(txtIPAddress.Text), Convert.ToInt32(txtPort.Text) );

            Socket server = new Socket(AddressFamily.InterNetwork, 
                                       SocketType.Stream, 
                                       ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);
            }
            catch (SocketException ex)
            {
                txtReceiveDisplay.Text += "Unable to connect to server.";
                txtReceiveDisplay.Text += ex.ToString();
                return;
            }



            strRequest = txtRequest.Text;
            server.Send(Encoding.ASCII.GetBytes(strRequest));   // send off the request

            System.Threading.Thread.Sleep(1000);

            int recv = 0;
            while (server.Available>0)                          // let's read the response and print it out
            {
                recv = server.Receive(data);

                stringData = Encoding.ASCII.GetString(data, 0, recv);

                // check if this is an image being returned ... the HTTPTool doesn't have the ability to 
                // support an image in the RESPONSE window ... so don't encode the returned data into ASCII 
                //   -- instead, output "IMAGE CONTENTS"
                //   -- assuming that the first occurance of the "\r\n\r\n" happens just before the encoded image contents
                //
                int isImage = stringData.IndexOf("Content-Type: image/jpeg");
                if(isImage > 0)
                {
                    // find the \r\n\r\n and cut the string short at that point
                    int imageStart = stringData.IndexOf("\r\n\r\n");
                    txtReceiveDisplay.Text += stringData.Substring(0, imageStart) + "\r\n\r\n[IMAGE DATA Found Here ...]\r\n";

                }
                else
                {
                    txtReceiveDisplay.Text += stringData + "\r\n";      // simply add the entire response
                }
            }
            

            txtReceiveDisplay.Text += "Disconnecting from server...\r\n";
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

        // pre-canned GET message
        private void btnInsertHTTP_Click(object sender, EventArgs e)
        {
            txtRequest.SelectedText = "GET /WDD/M-05/asp/S-02-Form-with-Postback.asp HTTP/1.1\r\n"
                               + "HOST: localhost\r\n"
                               + "\r\n";
         }

        // pre-canned POST message
        private void btnInsertPost_Click(object sender, EventArgs e)
        {
            txtRequest.SelectedText = "POST /WDD/M-07/php/S-03-Session-2.php HTTP/1.1\r\n"
                                    + "HOST: localhost\r\n"
                                    + "Content-Type: application/x-www-form-urlencoded\r\n"
                                    + "Content-Length: 10\r\n"
                                    + "\r\n"
                                    + "fname=Sean";

        }

        // how many bytes came back in the response?
        private void btnCountSelected_Click(object sender, EventArgs e)
        {
            int nCount = txtReceiveDisplay.SelectionLength;
            if(nCount == 0)
            {
                MessageBox.Show("Sorry, but you need to highlight (select) some text in the RESPONSE to count.");
            }
            else
            {
                MessageBox.Show("Number of characters: " + nCount.ToString());
            }
        }

        // clear the send and receive buffer spaces
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceiveDisplay.Clear();
        }

        private void ClearSend_Click(object sender, EventArgs e)
        {
            txtRequest.Clear();
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            txtRequest.SelectedText = "GET /WDD/M-05/asp/images/calendar.jpg HTTP/1.1\r\n"
                               + "HOST: localhost\r\n"
                               + "\r\n";


        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            string whichResource = txtGetResource.Text;
            if (whichResource.Length == 0)
            {
                MessageBox.Show("Sorry, but you need to enter a RESOURCE to GET in the textbox.");
            }
            else
            {
                txtRequest.SelectedText = "GET "+whichResource+" HTTP/1.1\r\n"
                                  + "HOST: localhost\r\n"
                                  + "\r\n";
            }
        }
    }
}
