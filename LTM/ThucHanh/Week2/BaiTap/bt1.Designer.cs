
namespace BaiTap
{
    partial class bt1
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
            this.ReadTextBox = new System.Windows.Forms.RichTextBox();
            this.WriteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadBut
            // 
            this.ReadBut.Location = new System.Drawing.Point(140, 369);
            this.ReadBut.Name = "ReadBut";
            this.ReadBut.Size = new System.Drawing.Size(75, 23);
            this.ReadBut.TabIndex = 0;
            this.ReadBut.Text = "Đọc";
            this.ReadBut.UseVisualStyleBackColor = true;
            this.ReadBut.Click += new System.EventHandler(this.ReadBut_Click);
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.Location = new System.Drawing.Point(61, 36);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(670, 283);
            this.ReadTextBox.TabIndex = 2;
            this.ReadTextBox.Text = "";
            // 
            // WriteBut
            // 
            this.WriteBut.Location = new System.Drawing.Point(582, 369);
            this.WriteBut.Name = "WriteBut";
            this.WriteBut.Size = new System.Drawing.Size(75, 23);
            this.WriteBut.TabIndex = 3;
            this.WriteBut.Text = "Ghi";
            this.WriteBut.UseVisualStyleBackColor = true;
            this.WriteBut.Click += new System.EventHandler(this.WriteBut_Click);
            // 
            // bt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteBut);
            this.Controls.Add(this.ReadTextBox);
            this.Controls.Add(this.ReadBut);
            this.Name = "bt1";
            this.Text = "bt1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadBut;
        private System.Windows.Forms.RichTextBox ReadTextBox;
        private System.Windows.Forms.Button WriteBut;
    }
}