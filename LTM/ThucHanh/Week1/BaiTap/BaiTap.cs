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
    public partial class BaiTap : Form
    {
        public BaiTap()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            Lab1_Bai1 l1b1 = new Lab1_Bai1();
            l1b1.ShowDialog();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 l1b2 = new Lab1_Bai2();
            l1b2.ShowDialog();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 l1b3 = new Lab1_Bai3();
            l1b3.ShowDialog();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 l1b4 = new Lab1_Bai4();
            l1b4.ShowDialog();
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 l1b5 = new Lab1_Bai5();
            l1b5.ShowDialog();
        }
    }
}
