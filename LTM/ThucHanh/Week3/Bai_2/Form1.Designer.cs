
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ListenBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListenBut;
        private System.Windows.Forms.RichTextBox MessageTB;
    }
}

