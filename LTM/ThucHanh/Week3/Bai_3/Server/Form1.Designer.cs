
namespace Bai_2
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
            this.ListenBut = new System.Windows.Forms.Button();
            this.MessageTB = new System.Windows.Forms.RichTextBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListenBut
            // 
            this.ListenBut.Location = new System.Drawing.Point(327, 324);
            this.ListenBut.Name = "ListenBut";
            this.ListenBut.Size = new System.Drawing.Size(90, 46);
            this.ListenBut.TabIndex = 0;
            this.ListenBut.Text = "Listen";
            this.ListenBut.UseVisualStyleBackColor = true;
            this.ListenBut.Click += new System.EventHandler(this.ListenBut_Click);
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(24, 122);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(393, 175);
            this.MessageTB.TabIndex = 1;
            this.MessageTB.Text = "";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(24, 72);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(163, 22);
            this.IPTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(327, 72);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(90, 22);
            this.PortTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ListenBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListenBut;
        private System.Windows.Forms.RichTextBox MessageTB;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortTextBox;
    }
}

