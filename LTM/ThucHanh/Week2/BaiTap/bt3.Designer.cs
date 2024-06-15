
namespace BaiTap
{
    partial class bt3
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
            this.CalBut = new System.Windows.Forms.Button();
            this.WriteTextBox = new System.Windows.Forms.RichTextBox();
            this.WriteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.Location = new System.Drawing.Point(41, 45);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(238, 283);
            this.ReadTextBox.TabIndex = 4;
            this.ReadTextBox.Text = "";
            // 
            // ReadBut
            // 
            this.ReadBut.Location = new System.Drawing.Point(122, 12);
            this.ReadBut.Name = "ReadBut";
            this.ReadBut.Size = new System.Drawing.Size(75, 23);
            this.ReadBut.TabIndex = 3;
            this.ReadBut.Text = "Đọc";
            this.ReadBut.UseVisualStyleBackColor = true;
            this.ReadBut.Click += new System.EventHandler(this.ReadBut_Click);
            // 
            // CalBut
            // 
            this.CalBut.Location = new System.Drawing.Point(358, 12);
            this.CalBut.Name = "CalBut";
            this.CalBut.Size = new System.Drawing.Size(75, 23);
            this.CalBut.TabIndex = 5;
            this.CalBut.Text = "Tính";
            this.CalBut.UseVisualStyleBackColor = true;
            this.CalBut.Click += new System.EventHandler(this.CalBut_Click);
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.Location = new System.Drawing.Point(503, 45);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(238, 283);
            this.WriteTextBox.TabIndex = 6;
            this.WriteTextBox.Text = "";
            // 
            // WriteBut
            // 
            this.WriteBut.Location = new System.Drawing.Point(587, 12);
            this.WriteBut.Name = "WriteBut";
            this.WriteBut.Size = new System.Drawing.Size(75, 23);
            this.WriteBut.TabIndex = 7;
            this.WriteBut.Text = "Ghi";
            this.WriteBut.UseVisualStyleBackColor = true;
            this.WriteBut.Click += new System.EventHandler(this.WriteBut_Click);
            // 
            // bt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteBut);
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.CalBut);
            this.Controls.Add(this.ReadTextBox);
            this.Controls.Add(this.ReadBut);
            this.Name = "bt3";
            this.Text = "bt3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadTextBox;
        private System.Windows.Forms.Button ReadBut;
        private System.Windows.Forms.Button CalBut;
        private System.Windows.Forms.RichTextBox WriteTextBox;
        private System.Windows.Forms.Button WriteBut;
    }
}