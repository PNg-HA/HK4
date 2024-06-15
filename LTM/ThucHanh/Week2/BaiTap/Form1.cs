using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_but_Click(object sender, EventArgs e)
        {
            bt1 b1 = new bt1();
            b1.ShowDialog();
        }

        private void bt2_but_Click(object sender, EventArgs e)
        {
            bt2 b2 = new bt2();
            b2.ShowDialog();
        }

        private void bt3_but_Click(object sender, EventArgs e)
        {
            bt3 b3 = new bt3();
            b3.ShowDialog();
        }

        private void bt5_but_Click(object sender, EventArgs e)
        {
            bt5 b5 = new bt5();
            b5.ShowDialog();
        }
    }
}
