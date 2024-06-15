using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace BaiTap
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            UdpClient cl = new UdpClient();
            Byte[] messageSend = Encoding.ASCII.GetBytes(MessageRTB.Text);
            cl.Send(messageSend, messageSend.Length,IPTextBox.Text, Int32.Parse(PortTextBox.Text));
        }
    }
}
