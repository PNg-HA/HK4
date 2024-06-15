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
    public partial class Lab1_Bai3 : Form
    {
        string[] numbers = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != "")
                InputTextBox.Text = "";
            resultTextBox.Text = "";
        }
        private Dictionary<int, string> danhMuc = new Dictionary<int, string>(){
            {1000000000, "tỷ"},
            {1000000, "triệu"},
            {1000, "ngàn"},
            {100, "trăm"},
            {90, "chín mươi"},
            {80, "tám mươi"},
            {70, "bảy mươi"},
            {60, "sáu mươi"},
            {50, "năm mươi"},
            {40, "bốn mươi"},
            {30, "ba mươi"},
            {20, "hai mươi"},
            {19, "mười chín"},
            {18, "mười tám"},
            {17, "mười bảy"},
            {16, "mười sáu"},
            {15, "mười lăm"},
            {14, "mười bốn"},
            {13, "mười ba"},
            {12, "mười hai"},
            {11, "mười một"},
            {10, "mười"},
            {9, "chín"},
            {8, "tám"},
            {7, "bảy"},
            {6, "sáu"},
            {5, "năm"},
            {4, "bốn"},
            {3, "ba"},
            {2, "hai"},
            {1, "một"}
        };
        //int numCheck = 1;
        private string NumberToWords(uint num)
        {
            //numCheck = 1;
            if (num == 0) return "không";
            string temp = ChuyenDoi(num);
            string[] array_temp = temp.Split(' ');
            if (array_temp[array_temp.Length - 2] == "một" && num % 100 >= 20)
            {
                array_temp[array_temp.Length - 2] = "mốt";
                return String.Join(" ", array_temp);
            }
            else
                return temp;
            
        }

        private string ChuyenDoi(uint num)
        {
            /*
            if (num <= 90 && num >= 20)
                hon20 = true;
            if (num == 1 && numCheck*10 >= num && checkFirstLoop == true)
            {
                if (hon20 == true)
                    return "mốt";
                else
                {
                    return "một ";
                }

            }
            MessageBox.Show("NUMCHECK: " + numCheck.ToString());
            MessageBox.Show(hon20.ToString());
            */
            foreach (uint key in danhMuc.Keys)
            {
                
                if (num >= key)
                {
/*                    numCheck *= 10;
                    checkFirstLoop = true;
                    hon20 = false;
*/
                    string kq = danhMuc[Convert.ToInt32(key)] + " " + ChuyenDoi(num % key);
                    if (num >= 100) 
                        kq = ChuyenDoi(num / key) + kq;                                      
                    
                    return kq;
                }
            }

            return "";

        }
        private void ReadBut_Click(object sender, EventArgs e)
        {
            try
            {
                int inputNumber = Int32.Parse(InputTextBox.Text.Trim());
                if (inputNumber < 0 || inputNumber > 9)
                {
                    throw new DataException();
                }
                switch (InputTextBox.Text.Trim())
                {
                    case "-0":
                        resultTextBox.Text = numbers[0];
                        break;
                    case "0":
                        resultTextBox.Text = numbers[0];
                        break;
                    case "1":
                        resultTextBox.Text = numbers[1];
                        break;
                    case "2":
                        resultTextBox.Text = numbers[2];
                        break;
                    case "3":
                        resultTextBox.Text = numbers[3];
                        break;
                    case "4":
                        resultTextBox.Text = numbers[4];
                        break;
                    case "5":
                        resultTextBox.Text = numbers[5];
                        break;
                    case "6":
                        resultTextBox.Text = numbers[6];
                        break;
                    case "7":
                        resultTextBox.Text = numbers[7];
                        break;
                    case "8":
                        resultTextBox.Text = numbers[8];
                        break;
                    case "9":
                        resultTextBox.Text = numbers[9];
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm");
            }
            catch (DataException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương < 10");
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm");
            }

        }

        private void AdvancedReadBut_Click(object sender, EventArgs e)
        {
            try
            {
                uint inputNumber = UInt32.Parse(InputTextBox.Text.Trim());
                resultTextBox.Text = NumberToWords(inputNumber);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm");
            }
            catch (DataException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm");
            }
        }

        private void exit_but_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
