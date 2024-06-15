using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Client cl;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void ConnectBut_Click(object sender, EventArgs e)
        {
            
            try
            {
                cl = new Client(IPTextBox.Text, PortTextBox.Text);
                cl.connect();
                SendButton.Enabled = true;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please type correct IP ");
            }
            catch (SocketException)
            {
                MessageBox.Show("Server not found");
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                cl.SendData(MessageTextBox.Text);
                MessageShowed.Text += MessageTextBox.Text + '\n';
                cl.CloseConnect();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please type the message");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendButton.Enabled = false;
        }
    }
}
