using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Form2
{
    public partial class Form2 : Form
    {
        //System.Timers.Timer t;
        int inputn1, value1, value2, inputn2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            value1 = 0;
            inputn1 = Convert.ToInt32(InputBox.Text);
            button1.Enabled = false;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            value2 = 0;
            inputn2 = Convert.ToInt32(InputBox.Text);
            button2.Enabled = false;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            value2 += 2;
            n2.Text = value2.ToString();
            if ((inputn2 < value2 + 1) && (inputn2 % 2 == 0))
            {
                button2.Enabled = true;
                timer2.Stop();
            }
            if ((inputn2 <= value2 + 2) && (inputn2 % 2 == 1))
            {
                value2++; 
                n2.Text = value2.ToString();
                button2.Enabled = true;
                timer2.Stop();
                //n2.Text = inputn2.ToString();
            }
        }

        private void timer1_Click(object sender, EventArgs e)
        {
            value1 += 1;
            n1.Text = value1.ToString();
            if (inputn1 < value1+1)
            {
                button1.Enabled = true;
                timer1.Stop();
            }
            
        }
    }
}
