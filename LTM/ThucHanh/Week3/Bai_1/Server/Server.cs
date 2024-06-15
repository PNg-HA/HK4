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
namespace BaiTap
{
    public partial class Server : Form
    {
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
                Byte[] messReceived = udpClient.Receive(ref IPendpoint);
                string data = Encoding.ASCII.GetString(messReceived);
                string mess = IPendpoint.Address.ToString() + ":" + data.ToString() + '\n';
                MessageRTB.Text += mess;
            }
        }

    }
}
