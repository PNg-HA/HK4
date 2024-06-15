using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace BaiTap
{
    public partial class Server : Form
    {
        int count = 0;
        public Server()
        {
            InitializeComponent();
        }

        private void ListenBut_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread server = new Thread(new ThreadStart(serverThread));
            server.Start();
        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Int32.Parse(PortTextBox.Text));
            while (true)
            {
                IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Any, 0);
                if (count % 3 == 0)
                {
                    
                    // Receive the key
                    Byte[] pubKeyRcv = udpClient.Receive(ref IPendpoint);
                    //MessageBox.Show(count.ToString());
                    // Save the pubKey
                    if (count < 3)
                    {
                        string filepath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Server\pubkey.key";
                        File.WriteAllBytes(filepath, pubKeyRcv);
                    }
                    

                }

                else if (count % 3 == 1)
                {
                    
                    // Receive the signature
                    Byte[] signatureRcv = udpClient.Receive(ref IPendpoint);
                    //MessageBox.Show(count.ToString());
                    // Save the signature
                    string filepath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Server\signature.txt";
                    File.WriteAllBytes(filepath, signatureRcv);
                    if (count >= 3)
                    {
                        // Show the signature
                        string data = Encoding.ASCII.GetString(signatureRcv);
                        string sign = IPendpoint.Address.ToString() + ": " + data.ToString() + '\n';
                        SignTextBox.Text += sign + '\n';
                    }
                        
                }
                else if (count % 3 == 2)
                {
                    
                    // Receive the message
                    Byte[] MessageRcv = udpClient.Receive(ref IPendpoint);
                    //MessageBox.Show(count.ToString());
                    // Save the pubKey
                    string filepath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Server\message.txt";
                    File.WriteAllBytes(filepath, MessageRcv);
                    if (count >= 3)
                    {
                        // Show the signature
                        string messRcv = Encoding.ASCII.GetString(MessageRcv);
                        string mess = IPendpoint.Address.ToString() + ": " + messRcv.ToString() + '\n';
                        MessageRTB.Text += mess + '\n';
                    }
                    
                }
                count++;        
                
            }
        }

    }
}
