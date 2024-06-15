
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
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.HTMLTextBox = new System.Windows.Forms.TextBox();
            this.ResponseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // URITextBox
            // 
            this.URITextBox.Location = new System.Drawing.Point(41, 21);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(274, 22);
            this.URITextBox.TabIndex = 1;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(750, 21);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(89, 25);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // HTMLTextBox
            // 
            this.HTMLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLTextBox.Location = new System.Drawing.Point(41, 67);
            this.HTMLTextBox.Multiline = true;
            this.HTMLTextBox.Name = "HTMLTextBox";
            this.HTMLTextBox.ReadOnly = true;
            this.HTMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTMLTextBox.Size = new System.Drawing.Size(640, 478);
            this.HTMLTextBox.TabIndex = 10;
            // 
            // ResponseRichTextBox
            // 
            this.ResponseRichTextBox.Location = new System.Drawing.Point(750, 67);
            this.ResponseRichTextBox.Name = "ResponseRichTextBox";
            this.ResponseRichTextBox.Size = new System.Drawing.Size(568, 478);
            this.ResponseRichTextBox.TabIndex = 11;
            this.ResponseRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 557);
            this.Controls.Add(this.ResponseRichTextBox);
            this.Controls.Add(this.HTMLTextBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.URITextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox URITextBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox HTMLTextBox;
        private System.Windows.Forms.RichTextBox ResponseRichTextBox;
    }
}

