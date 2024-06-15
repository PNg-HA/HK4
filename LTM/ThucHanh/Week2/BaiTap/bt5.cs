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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BaiTap
{
    
    public partial class bt5 : Form
    {
        public bt5()
        {
            InitializeComponent();
            FolderDetailLV.View = View.Details;
            FolderDetailLV.GridLines = true;
            /*FolderDetailLV.FullRowSelect = false;*/
        }
        
        private void BrowseBut_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            urlTextBox.Text = fbd.SelectedPath;

            DirectoryInfo dir = new DirectoryInfo(urlTextBox.Text);
            FileInfo[] fiArr = dir.GetFiles();
            DirectoryInfo[] dirArr = dir.GetDirectories();
            foreach (DirectoryInfo di in dirArr)
            {
                ListViewItem item = FolderDetailLV.Items.Add(di.Name);
                item.SubItems.Add(di.CreationTime.ToString("MMMM dd, yyyy"));
                item.SubItems.Add("File folder");
            }

            foreach (FileInfo fi in fiArr)
            {
                long size = fi.Length / 1024;
                ListViewItem item = FolderDetailLV.Items.Add(fi.Name);
                item.SubItems.Add(fi.CreationTime.ToString("MMMM dd, yyyy"));
                item.SubItems.Add(fi.Extension);
                item.SubItems.Add(size.ToString() + "KB");
            }
        }
    }
}
