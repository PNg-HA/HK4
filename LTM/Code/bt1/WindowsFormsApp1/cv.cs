using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp1
{
	public partial class cv : Form
	{
		public cv()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{	if (button1.Text == "Hiển thị"){
				label10.Visible = true;
				label11.Visible = true;
				label9.Visible = true;
				button1.Text = "Ẩn";
			}
			else if (button1.Text == "Ẩn"){
				label10.Visible = false;
				label11.Visible = false;
				label9.Visible = false;
				button1.Text = "Hiển thị";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/PNg-HA?tab=repositories");
		}

		private void label12_Click(object sender, EventArgs e)
		{

		}
	}
}
