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
using System.IO;

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
            // Read pubkeyFile in byte format
            byte[] pubkey;
            string keypath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Client\pubkey.key";
            pubkey = File.ReadAllBytes(keypath);

            UdpClient cl = new UdpClient();

            // Send the pubkey to a host
            cl.Send(pubkey, pubkey.Length, IPTextBox.Text, Int32.Parse(PortTextBox.Text));

            // Load the signature from file
            string SignaturePath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Client\signature.txt";
            StreamReader sr = new StreamReader(SignaturePath); // create a stream reader file from OpenFileDialog
            SignatureRTB.Text = sr.ReadToEnd();

            // Send the signature to server
            Byte[] SignatureSent = Encoding.ASCII.GetBytes(SignatureRTB.Text);
            cl.Send(SignatureSent, SignatureSent.Length, IPTextBox.Text, Int32.Parse(PortTextBox.Text));

            // Load the message from file
            string MessagePath = @"D:\Move\UIT\HK4\MMH\ThucHanh\Lab3\Code\Bai_Luyen_tap_2\Bai_1\Client\message.txt";
            StreamReader sr2 = new StreamReader(MessagePath); // create a stream reader file from OpenFileDialog
            MessageRTB.Text = sr2.ReadToEnd();

            // Send the signature to server
            Byte[] MessageSent = Encoding.ASCII.GetBytes(MessageRTB.Text);
            cl.Send(MessageSent, MessageSent.Length, IPTextBox.Text, Int32.Parse(PortTextBox.Text));
        }
    }
}
