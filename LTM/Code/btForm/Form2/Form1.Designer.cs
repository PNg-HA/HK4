
namespace Form2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.CountText2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.CountText1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Count 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập 1 số";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Count 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(251, 48);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(217, 30);
            this.InputBox.TabIndex = 4;
            // 
            // CountText2
            // 
            this.CountText2.AutoSize = true;
            this.CountText2.Location = new System.Drawing.Point(591, 116);
            this.CountText2.Name = "CountText2";
            this.CountText2.Size = new System.Drawing.Size(135, 17);
            this.CountText2.TabIndex = 5;
            this.CountText2.Text = "Count to number (2)";
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(123, 199);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(36, 39);
            this.n1.TabIndex = 6;
            this.n1.Text = "0";
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(587, 199);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(36, 39);
            this.n2.TabIndex = 7;
            this.n2.Text = "0";
            // 
            // CountText1
            // 
            this.CountText1.AutoSize = true;
            this.CountText1.Location = new System.Drawing.Point(108, 116);
            this.CountText1.Name = "CountText1";
            this.CountText1.Size = new System.Drawing.Size(135, 17);
            this.CountText1.TabIndex = 8;
            this.CountText1.Text = "Count to number (1)";
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountText1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.CountText2);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label CountText2;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label CountText1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

