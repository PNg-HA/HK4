
namespace Client
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
            this.SendButton = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageShowed = new System.Windows.Forms.RichTextBox();
            this.ConnectBut = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(406, 377);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 56);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(12, 44);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(100, 22);
            this.IPTextBox.TabIndex = 1;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(262, 44);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Server";
            // 
            // MessageShowed
            // 
            this.MessageShowed.Location = new System.Drawing.Point(15, 122);
            this.MessageShowed.Name = "MessageShowed";
            this.MessageShowed.Size = new System.Drawing.Size(347, 234);
            this.MessageShowed.TabIndex = 5;
            this.MessageShowed.Text = "";
            // 
            // ConnectBut
            // 
            this.ConnectBut.Location = new System.Drawing.Point(406, 300);
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.Size = new System.Drawing.Size(95, 56);
            this.ConnectBut.TabIndex = 7;
            this.ConnectBut.Text = "Connect";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.ConnectBut_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 377);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(350, 56);
            this.MessageTextBox.TabIndex = 8;
            this.MessageTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message sent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ConnectBut);
            this.Controls.Add(this.MessageShowed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MessageShowed;
        private System.Windows.Forms.Button ConnectBut;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label label3;
    }
}

