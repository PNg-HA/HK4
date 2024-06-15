using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Net;
namespace ConsoleApp1
{
    public class NewUser
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;

        public void StartClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(DoChat);
            ctThread.Start();
        }

        private void DoChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();

                    int bytesRead = networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    string returndata = Encoding.ASCII.GetString(bytesFrom, 0, bytesRead);

                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine("From client - " + clNo + " : " + dataFromClient);
                    rCount = Convert.ToString(requestCount);

                    Program.broadcast(dataFromClient, clNo, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
    class Program
    {
        public static Hashtable clientsList = new Hashtable();

        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + ": " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }
        public static void Main(string[] args)
        {
            TcpListener serverSocket = null;

            // Bind()
            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            serverSocket = new TcpListener(localAddr, port);

            // Listen
            serverSocket.Start();

            TcpClient clientSocket;
            

            
            Console.WriteLine("Chat room server running on 127.0.0.1:" + port.ToString());
            while ((true))
            {
                
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("New client connected from " + clientSocket.Client.RemoteEndPoint.ToString());
                byte[] bytesFrom = new byte[10025];
                string dataFromClient;

                NetworkStream networkStream = clientSocket.GetStream();

                int bytesRead = networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                dataFromClient = Encoding.ASCII.GetString(bytesFrom, 0, bytesRead);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                // add client to a hash table: (key, value) = (client info, client socket)
                clientsList.Add(dataFromClient, clientSocket);

                broadcast(dataFromClient + " Joined ", dataFromClient, false);

                Console.WriteLine(dataFromClient + " Joined chat room ");
                
                // add new user 
                NewUser client = new NewUser();
                client.StartClient(clientSocket, dataFromClient, clientsList);
            }

            // Close connection
            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }
    }
}
