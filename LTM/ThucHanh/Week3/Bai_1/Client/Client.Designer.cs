
namespace BaiTap
{
    partial class Client
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
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.MessageRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(566, 82);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 14;
            // 
            // MessageRTB
            // 
            this.MessageRTB.Location = new System.Drawing.Point(138, 184);
            this.MessageRTB.Name = "MessageRTB";
            this.MessageRTB.Size = new System.Drawing.Size(434, 163);
            this.MessageRTB.TabIndex = 13;
            this.MessageRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "message";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(138, 82);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(100, 22);
            this.IPTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP remote host";
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(138, 365);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(75, 23);
            this.SendBut.TabIndex = 8;
            this.SendBut.Text = "Send";
            this.SendBut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.MessageRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBut);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.RichTextBox MessageRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendBut;
    }
}