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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = "";
            if (textBox2.Text != "")
                textBox2.Text = "";
            if (textBox3.Text != "")
                textBox3.Text = "";
            MinTextBox.Text = "";
            MaxTextBox.Text = "";
        }
        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            try
            {
                float max = 0, min = 0;
                float num1 = float.Parse(textBox1.Text.Trim());
                float num2 = float.Parse(textBox2.Text.Trim());
                float num3 = float.Parse(textBox3.Text.Trim());
                if (num1 <= num2)
                {
                    if (num2 <= num3)
                    {
                        max = num3;
                        min = num1;
                    }
                    else
                    {
                        max = num2;
                        if (num1 <= num3)
                        {
                            min = num1;
                        }
                        else
                        {
                            min = num3;
                        }
                    }

                }
                else // num2 < num1
                {
                    if (num1 <= num3)
                    {
                        max = num3;
                        min = num2;
                    }
                    else // num3 < num1
                    {
                        max = num1;
                        if (num2 <= num3)
                        {
                            min = num2;
                        }
                        else
                        {
                            min = num3;
                        }
                    }                    
                }
                MinTextBox.Text = min.ToString();
                MaxTextBox.Text = max.ToString();
            }
            catch (FormatException)
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
                else
                    MessageBox.Show("Vui lòng nhập số thực");
            }

        }
    }
}
