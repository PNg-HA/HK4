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
namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void unsafeThread()
        {
            int bytesRcv = 0;

            byte[] recv = new byte[1];
            Socket clSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipSv = new IPEndPoint(IPAddress.Any, 8080);

            listenerSocket.Bind(ipSv);
            //start to listen
            listenerSocket.Listen(-1);

            clSocket = listenerSocket.Accept();
            // Rcv data
            MessageTB.Text += "New client" + '\n';
            while (clSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesRcv = clSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                MessageTB.Text += text + '\n';
            }
        }
        private void ListenBut_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread svThread = new Thread(
                new ThreadStart(unsafeThread)
            );
            svThread.Start();
        }
    }
}
