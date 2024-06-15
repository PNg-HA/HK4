
namespace BaiTap
{
    partial class Lab1_Bai4
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
            this.Tittle = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            this.convertBut = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.ComboBox();
            this.ToBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(138, 54);
            this.Tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(221, 25);
            this.Tittle.TabIndex = 29;
            this.Tittle.Text = "Convert HEX, DEC, BIN";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(197, 385);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(188, 22);
            this.resultTextBox.TabIndex = 28;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(104, 381);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 25);
            this.ResultLabel.TabIndex = 27;
            this.ResultLabel.Text = "Kết quả";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(197, 120);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(188, 22);
            this.InputTextBox.TabIndex = 26;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(104, 116);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(85, 25);
            this.InputLabel.TabIndex = 25;
            this.InputLabel.Text = "Nhập số";
            // 
            // exit_but
            // 
            this.exit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.Location = new System.Drawing.Point(109, 313);
            this.exit_but.Margin = new System.Windows.Forms.Padding(4);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(276, 41);
            this.exit_but.TabIndex = 24;
            this.exit_but.Text = "Thoát";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_but.Location = new System.Drawing.Point(287, 250);
            this.del_but.Margin = new System.Windows.Forms.Padding(4);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(98, 41);
            this.del_but.TabIndex = 23;
            this.del_but.Text = "Xóa";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // convertBut
            // 
            this.convertBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBut.Location = new System.Drawing.Point(109, 250);
            this.convertBut.Name = "convertBut";
            this.convertBut.Size = new System.Drawing.Size(140, 41);
            this.convertBut.TabIndex = 22;
            this.convertBut.Text = "Thực hiện";
            this.convertBut.UseVisualStyleBackColor = true;
            this.convertBut.Click += new System.EventHandler(this.convertBut_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(104, 182);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(36, 25);
            this.fromLabel.TabIndex = 30;
            this.fromLabel.Text = "Từ";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(237, 181);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(48, 25);
            this.ToLabel.TabIndex = 31;
            this.ToLabel.Text = "Đến";
            // 
            // FromBox
            // 
            this.FromBox.FormattingEnabled = true;
            this.FromBox.Items.AddRange(new object[] {
            "binary",
            "decimal",
            "hex"});
            this.FromBox.Location = new System.Drawing.Point(143, 182);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(89, 24);
            this.FromBox.TabIndex = 33;
            // 
            // ToBox
            // 
            this.ToBox.FormattingEnabled = true;
            this.ToBox.Items.AddRange(new object[] {
            "binary",
            "decimal",
            "hex"});
            this.ToBox.Location = new System.Drawing.Point(287, 183);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(98, 24);
            this.ToBox.TabIndex = 34;
            // 
            // Lab1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.convertBut);
            this.Name = "Lab1_Bai4";
            this.Text = "Lab1_Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button convertBut;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox FromBox;
        private System.Windows.Forms.ComboBox ToBox;
    }
}