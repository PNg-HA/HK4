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
namespace BaiTap
{
    public partial class bt2 : Form
    {
        public bt2()
        {
            InitializeComponent();
        }
        private int CountLine(string url)
        {
            int lCount = 0;
            StreamReader sr = new StreamReader(url);
            while (sr.ReadLine() != null) { //until reach EOF,
                lCount++;  // increment the line number
            }
            return lCount;
        }
        private void ReadBut_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog(); // Create a open-file window
                ofd.ShowDialog();
                StreamReader sr = new StreamReader(ofd.FileName); // create a stream reader file from OpenFileDialog
                ReadTextBox.Text = sr.ReadToEnd(); //read file from OpenFileDialog

                FileNameText.Text = ofd.SafeFileName; // File name
                UrlText.Text = ofd.FileName; // File location
                CharText.Text = ReadTextBox.Text.Length.ToString(); // Character number of the file
                WordText.Text = ReadTextBox.Text.Split(' ').Count().ToString();
                LineText.Text = CountLine(ofd.FileName).ToString(); // Line number of the file
            }
            catch
            {
                MessageBox.Show("Chưa chọn file chính xác");
            }
        }
    }
}
