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
    public partial class Lab1_Bai5 : Form
    {
        int constWidth = 100, constHeight = 130;  //Width and Height of dynamic labels
        float TotalMark = 0, markMin = 10, markMax = 0;
        int monRot = 0, monDau = 0, soMon = 0;
        public Lab1_Bai5()
        {
            InitializeComponent();
        }
        private string HocLuc (double dtb, int MD2, int MD3P5, int MD5, int MD6P5) //MD: Môn dưới
        {
            if (dtb >= 8 && MD6P5 == 0)
            {
                return "Giỏi";
            }
            else if (dtb >= 6.5 && MD5 == 0)
            {
                return "Khá";
            }
            else if (dtb >= 5 && MD3P5 == 0)
            {
                return "TB";
            }
            else if (dtb >= 3.5 && MD2 == 0)
            {
                return "Yếu";
            }
            else 
            {
                return "Kém";
            }
            
            
                   
        }
        private void OutBut_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var k in InputTextBox.Text)
                {
                    if (k == ',')
                    {
                        throw new FormatException();
                    }
                }
                string[] DS_Diem = InputTextBox.Text.Split(' ');
                soMon = DS_Diem.Count();
                int SubjectLessThan2 = 0, SubjectLessThan3P5 = 0, SubjectLessThan5 = 0, SubjectLessThan6P5 = 0;
                for (int i = 0; i < soMon; i++)
                {
                    float mark_temp = float.Parse(DS_Diem[i]);
                    if (mark_temp < 0)
                        throw new Exception();
                    if (mark_temp < 2)
                    {
                        SubjectLessThan2++;
                    }
                    if (mark_temp < 3.5)
                    {
                        SubjectLessThan3P5++;
                    }
                    if (mark_temp < 5)
                    {
                        SubjectLessThan5++;
                    }
                    if (mark_temp < 6.5)
                    {
                        SubjectLessThan6P5++;
                    }
                    if (mark_temp < 5)
                    {
                        monRot++;
                    }
                    if (mark_temp < markMin)
                    {
                        markMin = mark_temp;
                    }
                    if (mark_temp > markMax)
                    {
                        markMax = mark_temp;
                    }
                    TotalMark += mark_temp;
                }
                FailLabel.Text += monRot.ToString();
                monDau = soMon - monRot;
                PassLabel.Text += monDau.ToString();
                double DTB = TotalMark / soMon;
                DTBLabel.Text += DTB.ToString("N3");
                HocLucLabel.Text += HocLuc(DTB, SubjectLessThan2, SubjectLessThan3P5, SubjectLessThan5, SubjectLessThan6P5).ToString();
                MaxMarkLabel.Text += markMax.ToString();
                MinMarkLabel.Text += markMin.ToString();      
                MessageBox.Show("Đã nhập đúng");

                Label[] cacMonHoc = new Label[20];
                int tempWidth = constWidth, tempHeight = constHeight;
                for (int i = 0; i < soMon; i++)
                {

                    cacMonHoc[i] = new Label();
                    cacMonHoc[i].Location = new Point(tempWidth, tempHeight);
                    cacMonHoc[i].AutoSize = true;
                    cacMonHoc[i].Name = "text_box1" + i.ToString();
                    cacMonHoc[i].Text = "Môn " + (i + 1).ToString() + ": " + DS_Diem[i].ToString() + "đ";
                    this.Controls.Add(cacMonHoc[i]);
                    tempWidth += constWidth;
                    if ((i + 1) % 4 == 0)
                    {
                        tempHeight += cacMonHoc[i].Height;
                        tempWidth = constWidth;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai format!");
            }      
        }
    }
}
