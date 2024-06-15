
namespace BaiTap
{
    partial class bt2
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
            this.ReadTextBox = new System.Windows.Forms.RichTextBox();
            this.ReadBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LineText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CharText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.Location = new System.Drawing.Point(357, 50);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(417, 350);
            this.ReadTextBox.TabIndex = 4;
            this.ReadTextBox.Text = "";
            // 
            // ReadBut
            // 
            this.ReadBut.Location = new System.Drawing.Point(35, 48);
            this.ReadBut.Name = "ReadBut";
            this.ReadBut.Size = new System.Drawing.Size(263, 39);
            this.ReadBut.TabIndex = 3;
            this.ReadBut.Text = "Đọc";
            this.ReadBut.UseVisualStyleBackColor = true;
            this.ReadBut.Click += new System.EventHandler(this.ReadBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên file";
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(135, 142);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(163, 22);
            this.FileNameText.TabIndex = 6;
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(135, 199);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(163, 22);
            this.UrlText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url";
            // 
            // LineText
            // 
            this.LineText.Location = new System.Drawing.Point(135, 264);
            this.LineText.Name = "LineText";
            this.LineText.Size = new System.Drawing.Size(163, 22);
            this.LineText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số dòng";
            // 
            // WordText
            // 
            this.WordText.Location = new System.Drawing.Point(135, 323);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(163, 22);
            this.WordText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số từ";
            // 
            // CharText
            // 
            this.CharText.Location = new System.Drawing.Point(135, 376);
            this.CharText.Name = "CharText";
            this.CharText.Size = new System.Drawing.Size(163, 22);
            this.CharText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số ký tự";
            // 
            // bt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WordText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LineText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadTextBox);
            this.Controls.Add(this.ReadBut);
            this.Name = "bt2";
            this.Text = "bt2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadTextBox;
        private System.Windows.Forms.Button ReadBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameText;
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LineText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CharText;
        private System.Windows.Forms.Label label5;
    }
}