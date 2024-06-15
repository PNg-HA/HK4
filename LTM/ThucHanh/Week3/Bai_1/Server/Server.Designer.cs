
namespace BaiTap
{
    partial class Server
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListenBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(146, 87);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 16;
            this.PortTextBox.Text = "8080";
            // 
            // MessageRTB
            // 
            this.MessageRTB.Location = new System.Drawing.Point(136, 195);
            this.MessageRTB.Name = "MessageRTB";
            this.MessageRTB.Size = new System.Drawing.Size(434, 163);
            this.MessageRTB.TabIndex = 15;
            this.MessageRTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Received message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "port";
            // 
            // ListenBut
            // 
            this.ListenBut.Location = new System.Drawing.Point(580, 52);
            this.ListenBut.Name = "ListenBut";
            this.ListenBut.Size = new System.Drawing.Size(75, 23);
            this.ListenBut.TabIndex = 19;
            this.ListenBut.Text = "Listen";
            this.ListenBut.UseVisualStyleBackColor = true;
            this.ListenBut.Click += new System.EventHandler(this.ListenBut_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListenBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.MessageRTB);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.RichTextBox MessageRTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ListenBut;
    }
}