using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
namespace WindowsApplication2
{
    public partial class Client : Form
    {
        int already_connected_flag = 0;
        TcpClient clientSocket;
        NetworkStream serverStream;
        string readData = null;

        public Client()
        {
            InitializeComponent();
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (already_connected_flag == 0)
            {
                // Ebstablish the connect
                Connect();
            }            

            // send message
            byte[] outStream = Encoding.ASCII.GetBytes(textBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void Connect()
        {
            clientSocket = new TcpClient();
            readData = "Conected to Chat Server ...";
            print_message();

            // connect the listener socket
            clientSocket.Connect(IPAddress.Loopback, 13000);
            serverStream = clientSocket.GetStream();

            // Send message to chat box server
            byte[] outStream = Encoding.ASCII.GetBytes(textBox3.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            
            already_connected_flag = 1;

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                byte[] inStream = new byte[10025];
                int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                readData = "" + returndata;
                print_message();
            }
        }

        private void print_message()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(print_message));
            else
                ChatBoxRTB.Text = ChatBoxRTB.Text + '\n' + " >> " + readData;
        }

    }
}