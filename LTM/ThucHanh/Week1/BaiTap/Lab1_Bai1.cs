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
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void plus_but_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 operand1 = Int64.Parse(textBox1.Text.Trim());
                Int64 operand2 = Int64.Parse(textBox2.Text.Trim());
                Int64 result = operand1 + operand2;
                resultBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
                else 
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }
                
        private void sub_but_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 operand1 = Int64.Parse(textBox1.Text.Trim());
                Int64 operand2 = Int64.Parse(textBox2.Text.Trim());
                Int64 result = operand1 - operand2;
                resultBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
                else
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void mul_but_Click(object sender, EventArgs e)
        {
            try
            {

                Int64 operand1 = Int64.Parse(textBox1.Text.Trim());
                Int64 operand2 = Int64.Parse(textBox2.Text.Trim());
                Int64 result = operand1 * operand2;
                resultBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
                else
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void div_but_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 dividend = Int64.Parse(textBox1.Text.Trim());
                Int64 divisor = Int64.Parse(textBox2.Text.Trim());
                double result = dividend / (double)divisor;
                resultBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
                else
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Số dư phải khác 0.");
            }
        }
        private void del_but_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = "";
            if (textBox2.Text != "")
                textBox2.Text = "";
            resultBox.Text = "";
        }
        private void exit_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Label_1_Click(object sender, EventArgs e)
        {

        }
    }
}
