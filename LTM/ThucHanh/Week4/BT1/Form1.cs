using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetHTML(Uri szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();

            for (int i = 0; i < response.Headers.Count; ++i)
            {
                ResponseRichTextBox.Text += i.ToString() + ": " + response.Headers.Keys[i].ToString() + ": " + response.Headers[i].ToString() +'\n';
            }
            
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the TextBox
                //URITextBox.Clear();

                // Check whether the input is valid URI
                bool valid_uri_flag = Uri.TryCreate(URITextBox.Text, UriKind.Absolute, out Uri URI);

                // && uriResult.Scheme == Uri.UriSchemeHttp; // Option replacing "http://"
                if (valid_uri_flag == false)
                {
                    throw new FormatException();
                }
                HTMLTextBox.Text = GetHTML(URI);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid URI");
                URITextBox.Clear();
            }
            
        }
    }
}
