using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
System.Net.Http;
namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/7/78/T1logo_profile.png/revision/latest/scale-to-width-down/220?cb=20221015004607");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
            WebBro
            string url = textBox1.Text;
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            //rs.ContentType = "text/html";
            StreamReader sr = new StreamReader(rs.GetResponseStream());
            richTextBox1.Text = sr.ReadToEnd();
            string myEncodedString = HttpUtility.HtmlEncode(myString);
            //HtmlDocument hd = (HtmlDocument) richTextBox1.Text;
            sr.Close();
        }
    }
}
