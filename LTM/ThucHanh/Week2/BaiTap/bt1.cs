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
    public partial class bt1 : Form
    {
        public bt1()
        {
            InitializeComponent();
        }

        private void ReadBut_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog(); // Create a open-file window
                ofd.ShowDialog();
                StreamReader sr = new StreamReader(ofd.FileName); // create a stream reader file from OpenFileDialog
                ReadTextBox.Text = sr.ReadToEnd(); //read file from OpenFileDialog
            }
            catch 
            {
                MessageBox.Show("Chưa chọn file chính xác");
            }
        }

        private void WriteBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            sfd.ShowDialog();
            string CapString = ReadTextBox.Text.ToUpper();  // Convert the string to be capitalized
            FileStream fs = new FileStream(sfd.FileName, FileMode.Append); // Create a stream that can create new file or append
            byte[] ct = Encoding.UTF8.GetBytes(CapString);
            fs.Write(ct, 0, ct.Length);
        }
    }
}
