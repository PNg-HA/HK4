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
using System.Text.RegularExpressions;

namespace BaiTap
{
    public partial class bt3 : Form
    {
        public bt3()
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

        private void CalBut_Click(object sender, EventArgs e)
        {
            try
            {
                string[] calArr = ReadTextBox.Text.Split('\n');
                for (int i = 0; i < calArr.Count(); i++)
                {
                    string charSeparators = @"([*\/]|(?<!E)[\+\-])";   // Separtor argument for Regex.Split function
                    string[] oper = Regex.Split(calArr[i], charSeparators); //ex: string "1+2" => 3 strings: "1", "+", "2"
                    int operator1 = Int32.Parse(oper[0]); // operator 1
                    int operator2 = Int32.Parse(oper[2]); // operator 2
                    if (operator2 == 0)  //Handle divide by 0
                    {
                        throw new DivideByZeroException();
                    }
                    float result = 0;
                    switch (oper[1])
                    {
                        case "+":
                            result = operator1 + operator2;
                            break;
                        case "-":
                            result = operator1 - operator2;
                            break;
                        case "*":
                            result = operator1 * operator2;
                            break;
                        case "/":
                            result = operator1 / (float)operator2;
                            break;
                    }
                    calArr[i] += ("= " + result.ToString());
                }
                WriteTextBox.Text =  string.Join("\n", calArr); //reunited the elements (each line) become the final string
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Không được chia 0");
            }
            catch (FormatException)
            {
                MessageBox.Show("File không chứa đúng format của phép toán.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Vui lòng đọc file trước.");
            }
        }

        private void WriteBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            sfd.ShowDialog();
            string CapString = WriteTextBox.Text;  // Convert the string to be capitalized
            FileStream fs = new FileStream(sfd.FileName, FileMode.Append); // Create a stream that can create new file or append
            byte[] ct = Encoding.UTF8.GetBytes(CapString);
            fs.Write(ct, 0, ct.Length);
        }

        
    }
}
