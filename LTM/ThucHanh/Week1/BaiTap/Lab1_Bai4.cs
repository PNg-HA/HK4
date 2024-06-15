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
    public partial class Lab1_Bai4 : Form
    {
        int[] binNums;
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void convertBut_Click(object sender, EventArgs e)
        {   
            try
            {
                if (FromBox.Text == ToBox.Text || FromBox.Text == "" || ToBox.Text == "")
                {
                    throw new DataException();
                }
                if (FromBox.Text == "binary" || FromBox.Text == "decimal")
                {
                    int inputNumber = Int32.Parse(InputTextBox.Text.Trim());
                    if (FromBox.Text == "decimal" && ToBox.Text == "binary")
                        resultTextBox.Text = Convert.ToString(inputNumber, 2);
                    if (FromBox.Text == "decimal" && ToBox.Text == "hex")
                        resultTextBox.Text = Convert.ToString(inputNumber, 16);

                    if (FromBox.Text == "binary" && ToBox.Text == "decimal")
                        resultTextBox.Text = Convert.ToInt32(InputTextBox.Text, 2).ToString();
                    if (FromBox.Text == "binary" && ToBox.Text == "hex")
                        resultTextBox.Text = Convert.ToInt32(InputTextBox.Text, 2).ToString("X");

                }
                if (FromBox.Text == "hex")
                {
                    if (ToBox.Text == "decimal")
                        resultTextBox.Text = int.Parse(InputTextBox.Text, System.Globalization.NumberStyles.HexNumber).ToString();
                    if(ToBox.Text == "binary")
                        resultTextBox.Text = Convert.ToString(Convert.ToInt64(InputTextBox.Text, 16), 2);
                }


            }
            catch (FormatException)
            {
                if (InputTextBox.Text == "")
                    MessageBox.Show("Vui lòng nhập số vào");
                else
                    MessageBox.Show("Vui lòng nhập đúng format số trong hệ cơ số của nó");
            }
            catch (DataException)
            {
                if (FromBox.Text == "" || ToBox.Text == "")
                    MessageBox.Show("Không được để trống format");
                else if (FromBox.Text == ToBox.Text)
                {
                    MessageBox.Show("Không được trùng format");
                }
                
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng format số trong hệ cơ số của nó");
            }
            
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";
            resultTextBox.Text = "";
        }
    }
}
