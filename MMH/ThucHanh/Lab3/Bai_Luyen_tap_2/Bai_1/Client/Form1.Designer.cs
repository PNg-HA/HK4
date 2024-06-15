
namespace BaiTap
{
    partial class Form1
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
            this.SendBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(115, 78);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(149, 46);
            this.SendBut.TabIndex = 0;
            this.SendBut.Text = "UDP Client";
            this.SendBut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 275);
            this.Controls.Add(this.SendBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendBut;
    }
}

