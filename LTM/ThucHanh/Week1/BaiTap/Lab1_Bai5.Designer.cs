
namespace BaiTap
{
    partial class Lab1_Bai5
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
            this.OutBut = new System.Windows.Forms.Button();
            this.Tittle = new System.Windows.Forms.Label();
            this.DTBLabel = new System.Windows.Forms.Label();
            this.HocLucLabel = new System.Windows.Forms.Label();
            this.ListMarkLabel = new System.Windows.Forms.Label();
            this.MaxMarkLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.MinMarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutBut
            // 
            this.OutBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutBut.Location = new System.Drawing.Point(550, 105);
            this.OutBut.Name = "OutBut";
            this.OutBut.Size = new System.Drawing.Size(75, 35);
            this.OutBut.TabIndex = 0;
            this.OutBut.Text = "Xuất";
            this.OutBut.UseVisualStyleBackColor = true;
            this.OutBut.Click += new System.EventHandler(this.OutBut_Click);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(305, 23);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(172, 31);
            this.Tittle.TabIndex = 1;
            this.Tittle.Text = "Quản lý điểm";
            // 
            // DTBLabel
            // 
            this.DTBLabel.AutoSize = true;
            this.DTBLabel.Location = new System.Drawing.Point(110, 235);
            this.DTBLabel.Name = "DTBLabel";
            this.DTBLabel.Size = new System.Drawing.Size(116, 17);
            this.DTBLabel.TabIndex = 2;
            this.DTBLabel.Text = "Điểm trung bình: ";
            // 
            // HocLucLabel
            // 
            this.HocLucLabel.AutoSize = true;
            this.HocLucLabel.Location = new System.Drawing.Point(332, 235);
            this.HocLucLabel.Name = "HocLucLabel";
            this.HocLucLabel.Size = new System.Drawing.Size(116, 17);
            this.HocLucLabel.TabIndex = 3;
            this.HocLucLabel.Text = "Xếp loại học lực: ";
            // 
            // ListMarkLabel
            // 
            this.ListMarkLabel.AutoSize = true;
            this.ListMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMarkLabel.Location = new System.Drawing.Point(84, 62);
            this.ListMarkLabel.Name = "ListMarkLabel";
            this.ListMarkLabel.Size = new System.Drawing.Size(185, 29);
            this.ListMarkLabel.TabIndex = 4;
            this.ListMarkLabel.Text = "Danh sách điểm";
            // 
            // MaxMarkLabel
            // 
            this.MaxMarkLabel.AutoSize = true;
            this.MaxMarkLabel.Location = new System.Drawing.Point(110, 278);
            this.MaxMarkLabel.Name = "MaxMarkLabel";
            this.MaxMarkLabel.Size = new System.Drawing.Size(136, 17);
            this.MaxMarkLabel.TabIndex = 5;
            this.MaxMarkLabel.Text = "Môn điểm cao nhất: ";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(110, 322);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(92, 17);
            this.PassLabel.TabIndex = 6;
            this.PassLabel.Text = "Số môn đậu: ";
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Location = new System.Drawing.Point(332, 322);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(135, 17);
            this.FailLabel.TabIndex = 7;
            this.FailLabel.Text = "Số môn không đậu: ";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(290, 67);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(335, 22);
            this.InputTextBox.TabIndex = 8;
            // 
            // MinMarkLabel
            // 
            this.MinMarkLabel.AutoSize = true;
            this.MinMarkLabel.Location = new System.Drawing.Point(332, 278);
            this.MinMarkLabel.Name = "MinMarkLabel";
            this.MinMarkLabel.Size = new System.Drawing.Size(141, 17);
            this.MinMarkLabel.TabIndex = 10;
            this.MinMarkLabel.Text = "Môn điểm thấp nhất: ";
            // 
            // Lab1_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinMarkLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MaxMarkLabel);
            this.Controls.Add(this.ListMarkLabel);
            this.Controls.Add(this.HocLucLabel);
            this.Controls.Add(this.DTBLabel);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.OutBut);
            this.Name = "Lab1_Bai5";
            this.Text = "Lab1_Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutBut;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label DTBLabel;
        private System.Windows.Forms.Label HocLucLabel;
        private System.Windows.Forms.Label ListMarkLabel;
        private System.Windows.Forms.Label MaxMarkLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label MinMarkLabel;
    }
}