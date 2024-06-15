using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
namespace Client
{using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
    using Org.BouncyCastle.Security;

    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        List<KeyValuePair<string, int>> serverIP_PortList = new List<KeyValuePair<string, int>>();
        NetworkStream stream;
        int already_TCPconnected_flag = 0;
        static string originFile = @"D:\Move\Resource\File.txt";
        static string encrFolder = @"D:\Move\EncryptFolder\";
        static string decrFolder = @"D:\Move\DecryptFolder\";
        static string encryptedFile = @"File.enc";
        string cert_serialNum = "58e70ec826eaaa6da4effe193f23e3b81eeb92fb";
        public Form1()
        {
            InitializeComponent();
            RawButton.Enabled = false;
            PreviewButton.Enabled = false;
            webBrowser.Visible = false;

            X509KeyStorageFlags flags = X509KeyStorageFlags.Exportable;
            X509Certificate2 cert = new X509Certificate2("D:\\Move\\UIT\\HK4\\LTM\\Project\\project_HTTPS-main\\project_HTTPS-main\\resources\\key.pfx", "", flags);
            X509Certificate2 cert2 = new X509Certificate2("D:\\Move\\UIT\\HK4\\LTM\\Project\\project_HTTPS-main\\project_HTTPS-main\\resources\\QuanNN.crt");
            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)cert.PrivateKey;
            if (cert.GetSerialNumberString().ToLower() == cert_serialNum)
                MessageBox.Show(cert.GetSerialNumberString());
            RSAParameters rsaParam = rsa.ExportParameters(true);
            var publick = (RSA)cert.PublicKey.Key;
            EncryptFile(originFile, publick);
            DecryptFile(encryptedFile, cert.GetRSAPrivateKey());
        }
        
        private static void EncryptFile(string inFile, RSA rsaPublicKey)
        {
            using (Aes aes = Aes.Create())
            {
                // Create instance of Aes for
                // symetric encryption of the data.
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                using (ICryptoTransform transform = aes.CreateEncryptor())
                {
                    RSAPKCS1KeyExchangeFormatter keyFormatter = new RSAPKCS1KeyExchangeFormatter(rsaPublicKey);
                    byte[] keyEncrypted = keyFormatter.CreateKeyExchange(aes.Key, aes.GetType());

                    // Create byte arrays to contain
                    // the length values of the key and IV.
                    byte[] LenK = new byte[4];
                    byte[] LenIV = new byte[4];

                    int lKey = keyEncrypted.Length;
                    LenK = BitConverter.GetBytes(lKey);
                    int lIV = aes.IV.Length;
                    LenIV = BitConverter.GetBytes(lIV);

                    // Write the following to the FileStream
                    // for the encrypted file (outFs):
                    // - length of the key
                    // - length of the IV
                    // - ecrypted key
                    // - the IV
                    // - the encrypted cipher content

                    int startFileName = inFile.LastIndexOf("\\") + 1;
                    // Change the file's extension to ".enc"
                    string outFile = encrFolder + inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";
                    Directory.CreateDirectory(encrFolder);

                    using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                    {

                        outFs.Write(LenK, 0, 4);
                        outFs.Write(LenIV, 0, 4);
                        outFs.Write(keyEncrypted, 0, lKey);
                        outFs.Write(aes.IV, 0, lIV);

                        // Now write the cipher text using
                        // a CryptoStream for encrypting.
                        using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {

                            // By encrypting a chunk at
                            // a time, you can save memory
                            // and accommodate large files.
                            int count = 0;
                            // blockSizeBytes can be any arbitrary size.
                            int blockSizeBytes = aes.BlockSize / 8;
                            byte[] data = new byte[blockSizeBytes];
                            int bytesRead = 0;

                            using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                            {
                                do
                                {
                                    MessageBox.Show(count.ToString());
                                    count = inFs.Read(data, 0, blockSizeBytes);
                                    outStreamEncrypted.Write(data, 0, count);
                                    bytesRead += count;
                                }
                                while (count > 0);
                                inFs.Close();
                            }
                            outStreamEncrypted.FlushFinalBlock();
                            outStreamEncrypted.Close();
                        }
                        outFs.Close();
                    }
                }
            }
        }

        private static void DecryptFile(string inFile, RSA rsaPrivateKey)
        {

            // Create instance of Aes for
            // symetric decryption of the data.
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;

                // Create byte arrays to get the length of
                // the encrypted key and IV.
                // These values were stored as 4 bytes each
                // at the beginning of the encrypted package.
                byte[] LenK = new byte[4];
                byte[] LenIV = new byte[4];

                // Construct the file name for the decrypted file.
                string outFile = decrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".txt";

                // Use FileStream objects to read the encrypted
                // file (inFs) and save the decrypted file (outFs).
                using (FileStream inFs = new FileStream(encrFolder + inFile, FileMode.Open))
                {

                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    // Convert the lengths to integer values.
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    // Determine the start position of
                    // the cipher text (startC)
                    // and its length(lenC).
                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    // Create the byte arrays for
                    // the encrypted Aes key,
                    // the IV, and the cipher text.
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    // Extract the key and IV
                    // starting from index 8
                    // after the length values.
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);
                    Directory.CreateDirectory(decrFolder);
                    // Use RSA
                    // to decrypt the Aes key.
                    byte[] KeyDecrypted = rsaPrivateKey.Decrypt(KeyEncrypted, RSAEncryptionPadding.Pkcs1);

                    // Decrypt the key.
                    using (ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV))
                    {

                        // Decrypt the cipher text from
                        // from the FileSteam of the encrypted
                        // file (inFs) into the FileStream
                        // for the decrypted file (outFs).
                        using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                        {

                            int count = 0;

                            int blockSizeBytes = aes.BlockSize / 8;
                            byte[] data = new byte[blockSizeBytes];

                            // By decrypting a chunk a time,
                            // you can save memory and
                            // accommodate large files.

                            // Start at the beginning
                            // of the cipher text.
                            inFs.Seek(startC, SeekOrigin.Begin);
                            using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                            {
                                do
                                {
                                    count = inFs.Read(data, 0, blockSizeBytes);
                                    outStreamDecrypted.Write(data, 0, count);
                                }
                                while (count > 0);

                                outStreamDecrypted.FlushFinalBlock();
                                outStreamDecrypted.Close();
                            }
                            outFs.Close();
                        }
                        inFs.Close();
                    }
                }
            }
        }
        private void print_message(string message)
        {
            if (RespHeadTextBox.InvokeRequired)
            {
                RespHeadTextBox.Invoke(new Action<string>(print_message), message);
                return;
            }
            string[] resp_items = message.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None);
            RespHeadTextBox.Text = "";
            BodyTextBox.Text = "";
            RespHeadTextBox.AppendText(resp_items[0] + Environment.NewLine);
            BodyTextBox.AppendText(resp_items[1] + Environment.NewLine);

            RawButton.Enabled = true;
            PreviewButton.Enabled = true;
            webBrowser.DocumentText = BodyTextBox.Text;
        }
        private void print_status(string message)
        {
            if ( statusLabel.InvokeRequired)
            {
                statusLabel.Invoke(new Action<string>(print_status), message);
                return;
            }
            string resp_line = message.Substring(0, message.IndexOf("\r\n"));
            string[] resp_line_items = resp_line.Split(' ');
            statusLabel.Text = "";
            for (int i = 1; i < resp_line_items.Length; i++)
            {
                statusLabel.Text += resp_line_items[i] + " ";
            }
        }
        private void ReceiveMessage()
        {
            stream = tcpClient.GetStream();
            string response = "";
            byte[] buffer = new byte[1024];
            while (true)
            {
                // receive response from server
                int b = stream.Read(buffer, 0, buffer.Length);

                // convert response from byte to string
                response = Encoding.ASCII.GetString(buffer, 0, b);
                MessageBox.Show(response);

                // Print the response to the sceen
                print_message(response);
                print_status(response);
                
                stream.Flush();
            }                
        }
        private string TLS_ClientHello()
        {
            string HandshakeType = "Client Hello";
            string TLSVersion = "Version: TLS1.2";

            // Generate a random 32-byte number
            byte[] BytesRandom = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(BytesRandom);
            }
            string hexRandomNumber = BitConverter.ToString(BytesRandom).Replace("-", "");

            // Generate a random 8-byte session ID
            byte[] ByteSessionID = new byte[8];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(ByteSessionID);
            }

            string SessionID = BitConverter.ToString(ByteSessionID).Replace("-", "");
            string CipherSuites = "TLS_RSA_WITH_AES_128_CBC_SHA";

            string ClientHelloMsg = "HandshakeType: " + HandshakeType + "\r\n"
                                    + TLSVersion + "\r\n"
                                    + "Random: "+ hexRandomNumber + "\r\n" 
                                    + "Session ID: " + SessionID + "\r\n"
                                    + "Cipher Suites: " + CipherSuites;
            return ClientHelloMsg;
        }
        private void SendMessage(string resource)
        {
            try
            {
                string ClientHello = TLS_ClientHello();
                MessageBox.Show(ClientHello);
                byte[] buffer = Encoding.ASCII.GetBytes(ClientHello);
                stream.Write(buffer, 0, buffer.Length);

                stream.Flush();
                string reqHeader = "";

                // body in case of POST, PUT
                string reqBody = "";
                string request = "";
                switch (MethodComboBox.Text)
                {
                    case "GET":
                        {
                            reqHeader = "GET /" + resource + " HTTP/1.1\r\n" // request line
                            // request headers
                               + "Host: " + ServIPTextBox.Text + "\r\n"
                               + "Connection: keep-alive \r\n"
                               + "Upgrade-Insecure-Requests: 1\r\n"
                               + "User-Agent: C# client\r\n"
                               + "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7\r\n"
                               + "Accept-Encoding: gzip, deflate\r\n"
                               + "Accept-Language: en-US,en;q=0.9\r\n"
                               + "\r\n"
                            ;
                            request = reqHeader;
                            MessageBox.Show(reqHeader);
                        }
                    break;
                    case "DELETE":
                        {
                            reqHeader = "DELETE /" + resource + " HTTP/1.1\r\n" // request line
                             // request headers
                               + "Host: " + ServIPTextBox.Text + "\r\n"
                               + "Connection: keep-alive \r\n"
                               + "Upgrade-Insecure-Requests: 1\r\n"
                               + "User-Agent: C# client\r\n"
                               + "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7\r\n"
                               + "Accept-Encoding: gzip, deflate\r\n"
                               + "Accept-Language: en-US,en;q=0.9\r\n"
                               + "\r\n"
                            ;
                            request = reqHeader;
                            MessageBox.Show(reqHeader);
                        }
                        break;
                    case "POST":
                        {
                            reqBody = "{\r\n  "
                                        + KeyComboBox.Text + ": " + ValueTextBox.Text + "\r\n"
                                        + "}\r\n";
                            // Header
                            reqHeader = "POST /" + resource + " HTTP/1.1\r\n" // request line
                               // request headers
                               + "Host: " + ServIPTextBox.Text + "\r\n"
                               + "Content-type: application/json\r\n"
                               + "Content-length: " + reqBody.Length + "\r\n"
                               + "Connection: keep-alive \r\n"
                               + "Upgrade-Insecure-Requests: 1\r\n"
                               + "User-Agent: C# client\r\n"
                               + "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7\r\n"
                               + "Accept-Encoding: gzip, deflate\r\n"
                               + "Accept-Language: en-US,en;q=0.9\r\n"
                               + "\r\n"
                            ;
                            request = reqHeader + reqBody;
                            MessageBox.Show(request);
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("HTTP Method Not Found!");
                        }
                        break;

                }
                // Send the request 
                
                buffer = Encoding.ASCII.GetBytes(request);
                // stream.Write(buffer, 0, buffer.Length);

               // stream.Flush();
            }
            catch (Exception ex)
            {
                // AddMessageToLog(ex.Message);
            }
        }
        private void EstablishTCPConnection()
        {
            try
            {
                already_TCPconnected_flag = 0;

                
                KeyValuePair<string, int> endpoint = new KeyValuePair<string, int>(ServIPTextBox.Text, Int32.Parse(ServPortTextBox.Text));
                if (serverIP_PortList == null) // first time start the connection
                {
                    // Create tcp client
                    tcpClient = new TcpClient();

                    // connect to the server socket
                    serverIP_PortList.Add(new KeyValuePair<string, int>(ServIPTextBox.Text, Int32.Parse(ServPortTextBox.Text)));
                    tcpClient.Connect(ServIPTextBox.Text, Int32.Parse(ServPortTextBox.Text));
                    stream = tcpClient.GetStream();
                    MessageBox.Show("Connected");
                }
                else // Check whether connection is existed
                {
                    foreach (var element in serverIP_PortList)
                    {
                        if (endpoint.Key == element.Key && endpoint.Value == element.Value)
                        {
                            already_TCPconnected_flag = 1;
                            break;
                        }
                    }
                    if (already_TCPconnected_flag == 0)
                    {
                        // Create tcp client
                        tcpClient = new TcpClient();

                        // connect to the server socket
                        serverIP_PortList.Add(new KeyValuePair<string, int>(ServIPTextBox.Text, Int32.Parse(ServPortTextBox.Text)));
                        tcpClient.Connect(ServIPTextBox.Text, Int32.Parse(ServPortTextBox.Text));
                        stream = tcpClient.GetStream();
                        MessageBox.Show("Connected");
                    }
                    
                }                             
                
                Task.Run(() => ReceiveMessage());

                // Replacement
                /*Thread ctThread = new Thread(ReceiveMessage);
                ctThread.Start();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // CheckCertificate();
        }

        private void MethodComboBox_TextChanged(object sender, EventArgs e)
        {
            if (MethodComboBox.Text == "POST")
            {
                ValueTextBox.Visible = true;
                ValueLabel.Visible = true;
                KeyComboBox.Visible = true;
                KeyLabel.Visible = true;
                SendButton.Location = new Point(168, 331);
            }
            if (MethodComboBox.Text == "GET")
            {
                ValueTextBox.Visible = false;
                ValueLabel.Visible = false;
                KeyComboBox.Visible = false;
                KeyLabel.Visible = false;
                SendButton.Location = new Point(168, 225);
            }
            if (MethodComboBox.Text == "DELETE")
            {
                ValueTextBox.Visible = false;
                ValueLabel.Visible = false;
                KeyComboBox.Visible = false;
                KeyLabel.Visible = false;
                SendButton.Location = new Point(168, 225);
            }
        }

        private void ResourceTextBox_Enter(object sender, EventArgs e)
        {
            
            SuggestLabel.Visible = false;
        }

        private void ResourceTextBox_Leave(object sender, EventArgs e)
        {
            if (ResourceTextBox.Text == "")
            {
                SuggestLabel.Visible = true;
            }
        }

        private void RawButton_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = false;
            BodyTextBox.Visible = true;
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = true;
            BodyTextBox.Visible = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            EstablishTCPConnection();
            SendMessage(ResourceTextBox.Text);
        }
    }
}
