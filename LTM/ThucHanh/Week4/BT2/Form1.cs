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

namespace BT2
{
    public partial class Form1 : Form
    {
        public void UserAgentControlInvisiblize()
        {
            UserAgentLabel.Visible = false;
            DefaultBrowserCheckBox.Visible = false;
            userAgentRichTextBox.Visible = false;
            userAgentComboBox.Visible = false;
            userAgentInfoLabel.Visible = false;
            CloseButton.Visible = false;
        }
        public void UserAgentControlVisiblize()
        {
            UserAgentLabel.Visible = true;
            DefaultBrowserCheckBox.Visible = true;
            userAgentRichTextBox.Visible = true;
            userAgentComboBox.Visible = true;
            userAgentInfoLabel.Visible = true;
            CloseButton.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
            HTMLTextBox.Visible = false;
            webBrowser.Visible = false;
            userAgentComboBox.Enabled = false;
            userAgentInfoLabel.Enabled = false;
            DefaultBrowserCheckBox.CheckState = CheckState.Checked;
            RawTextBox.Enabled = false;
            RenderTextBox.Enabled = false;
            UserAgentControlInvisiblize();
        }
        private string GetHTML(Uri szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();


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
                bool valid_uri_flag = Uri.TryCreate("https://" + URITextBox.Text, UriKind.Absolute, out Uri URI);

                // && uriResult.Scheme == Uri.UriSchemeHttp; // Option replacing "http://"
                if (valid_uri_flag == false)
                {
                    throw new FormatException();
                }
                HTMLTextBox.Text = GetHTML(URI);
                HTMLTextBox.Visible = true;
                webBrowser.Visible = false;
                RawTextBox.Enabled = true;
                RenderTextBox.Enabled = true;
                webBrowser.Navigate(URI);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid URI");
                URITextBox.Clear();
            }

        }

        private void RawTextBox_Click(object sender, EventArgs e)
        {
            HTMLTextBox.Visible = true;
            webBrowser.Visible = false;
        }

        private void RenderTextBox_Click(object sender, EventArgs e)
        {
            HTMLTextBox.Visible = false;
            webBrowser.Visible = true;
        }


        private void UserAgentButton_Click(object sender, EventArgs e)
        {
            UserAgentLabel.Visible = true;
            DefaultBrowserCheckBox.Visible = true;
            userAgentRichTextBox.Visible = true;
            userAgentComboBox.Visible = true;
            userAgentInfoLabel.Visible = true;
            CloseButton.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UserAgentControlInvisiblize();
        }

        private void DefaultBrowserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DefaultBrowserCheckBox.CheckState == CheckState.Checked){
                userAgentComboBox.Enabled = false;
                userAgentInfoLabel.Enabled = false;
                userAgentComboBox.Text = "";
                userAgentInfoLabel.Text = "user agent information";
            }
            else
            {
                userAgentComboBox.Enabled = true;
                userAgentInfoLabel.Enabled = true;
            }
        }
        private void userAgentComboBox_TextChanged(object sender, EventArgs e)
        {
            if (userAgentComboBox.Text == "Chrome - Windows")
            {
                userAgentInfoLabel.Text = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML)";
            }
            else if (userAgentComboBox.Text == "Safari - Iphone")
            {
                userAgentInfoLabel.Text = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X)";
            }
            else
            {
                userAgentInfoLabel.Text = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:70.0)";
            }
        }
    }
}
