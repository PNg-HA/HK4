using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Client
{
    public class Client
    {
        TcpClient tcpCl;
        IPEndPoint ipEndPoint;
        byte[] data;
        NetworkStream ns;

        public Client(string ip, string port)
        {
            tcpCl = new TcpClient();
            ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(port));
        }
        public void connect()
        {
            tcpCl.Connect(ipEndPoint);
            ns = tcpCl.GetStream();
        }
        public void SendData(string text)
        {           
            data = Encoding.ASCII.GetBytes(text+'\n');
            ns.Write(data, 0, data.Length);            
        }
        public void CloseConnect()
        {
            SendData("quit");
            ns.Close();
            tcpCl.Close();
        }
    }
}
