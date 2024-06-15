
namespace BaiTap
{
    partial class Lab1_Bai3
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
            this.ReadBut = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.AdvancedReadBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadBut
            // 
            this.ReadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBut.Location = new System.Drawing.Point(58, 218);
            this.ReadBut.Name = "ReadBut";
            this.ReadBut.Size = new System.Drawing.Size(163, 41);
            this.ReadBut.TabIndex = 0;
            this.ReadBut.Text = "Đọc cơ bản";
            this.ReadBut.UseVisualStyleBackColor = true;
            this.ReadBut.Click += new System.EventHandler(this.ReadBut_Click);
            // 
            // exit_but
            // 
            this.exit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.Location = new System.Drawing.Point(58, 313);
            this.exit_but.Margin = new System.Windows.Forms.Padding(4);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(376, 41);
            this.exit_but.TabIndex = 11;
            this.exit_but.Text = "Thoát";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click_1);
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_but.Location = new System.Drawing.Point(58, 264);
            this.del_but.Margin = new System.Windows.Forms.Padding(4);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(163, 41);
            this.del_but.TabIndex = 10;
            this.del_but.Text = "Xóa";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(116, 97);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(82, 22);
            this.InputTextBox.TabIndex = 18;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(23, 93);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(85, 25);
            this.InputLabel.TabIndex = 17;
            this.InputLabel.Text = "Nhập số";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(116, 146);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(318, 22);
            this.resultTextBox.TabIndex = 20;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(23, 142);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 25);
            this.ResultLabel.TabIndex = 19;
            this.ResultLabel.Text = "Kết quả";
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(114, 29);
            this.Tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(176, 25);
            this.Tittle.TabIndex = 21;
            this.Tittle.Text = "Nhập số không âm";
            // 
            // AdvancedReadBut
            // 
            this.AdvancedReadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedReadBut.Location = new System.Drawing.Point(263, 218);
            this.AdvancedReadBut.Name = "AdvancedReadBut";
            this.AdvancedReadBut.Size = new System.Drawing.Size(171, 87);
            this.AdvancedReadBut.TabIndex = 22;
            this.AdvancedReadBut.Text = "Đọc nâng cao";
            this.AdvancedReadBut.UseVisualStyleBackColor = true;
            this.AdvancedReadBut.Click += new System.EventHandler(this.AdvancedReadBut_Click);
            // 
            // Lab1_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.AdvancedReadBut);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.ReadBut);
            this.Name = "Lab1_Bai3";
            this.Text = "Lab1_Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadBut;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button AdvancedReadBut;
    }
}