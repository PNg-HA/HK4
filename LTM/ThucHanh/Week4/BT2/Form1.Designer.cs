
namespace BT2
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
            this.DownloadButton = new System.Windows.Forms.Button();
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.HTMLTextBox = new System.Windows.Forms.TextBox();
            this.RawTextBox = new System.Windows.Forms.Button();
            this.RenderTextBox = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.UserAgentButton = new System.Windows.Forms.Button();
            this.userAgentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DefaultBrowserCheckBox = new System.Windows.Forms.CheckBox();
            this.UserAgentLabel = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.Label();
            this.userAgentInfoLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.userAgentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(507, 27);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(145, 25);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // URITextBox
            // 
            this.URITextBox.Location = new System.Drawing.Point(12, 30);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(489, 22);
            this.URITextBox.TabIndex = 3;
            // 
            // HTMLTextBox
            // 
            this.HTMLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLTextBox.Location = new System.Drawing.Point(12, 89);
            this.HTMLTextBox.Multiline = true;
            this.HTMLTextBox.Name = "HTMLTextBox";
            this.HTMLTextBox.ReadOnly = true;
            this.HTMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTMLTextBox.Size = new System.Drawing.Size(640, 478);
            this.HTMLTextBox.TabIndex = 11;
            // 
            // RawTextBox
            // 
            this.RawTextBox.Location = new System.Drawing.Point(12, 58);
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.Size = new System.Drawing.Size(89, 25);
            this.RawTextBox.TabIndex = 12;
            this.RawTextBox.Text = "Raw";
            this.RawTextBox.UseVisualStyleBackColor = true;
            this.RawTextBox.Click += new System.EventHandler(this.RawTextBox_Click);
            // 
            // RenderTextBox
            // 
            this.RenderTextBox.Location = new System.Drawing.Point(107, 58);
            this.RenderTextBox.Name = "RenderTextBox";
            this.RenderTextBox.Size = new System.Drawing.Size(89, 25);
            this.RenderTextBox.TabIndex = 13;
            this.RenderTextBox.Text = "Render";
            this.RenderTextBox.UseVisualStyleBackColor = true;
            this.RenderTextBox.Click += new System.EventHandler(this.RenderTextBox_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 91);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(640, 478);
            this.webBrowser.TabIndex = 14;
            // 
            // UserAgentButton
            // 
            this.UserAgentButton.Location = new System.Drawing.Point(507, 58);
            this.UserAgentButton.Name = "UserAgentButton";
            this.UserAgentButton.Size = new System.Drawing.Size(145, 25);
            this.UserAgentButton.TabIndex = 16;
            this.UserAgentButton.Text = "User-Agent";
            this.UserAgentButton.UseVisualStyleBackColor = true;
            this.UserAgentButton.Click += new System.EventHandler(this.UserAgentButton_Click);
            // 
            // userAgentRichTextBox
            // 
            this.userAgentRichTextBox.Location = new System.Drawing.Point(12, 443);
            this.userAgentRichTextBox.Name = "userAgentRichTextBox";
            this.userAgentRichTextBox.Size = new System.Drawing.Size(640, 126);
            this.userAgentRichTextBox.TabIndex = 19;
            this.userAgentRichTextBox.Text = "";
            // 
            // DefaultBrowserCheckBox
            // 
            this.DefaultBrowserCheckBox.AutoSize = true;
            this.DefaultBrowserCheckBox.Location = new System.Drawing.Point(162, 445);
            this.DefaultBrowserCheckBox.Name = "DefaultBrowserCheckBox";
            this.DefaultBrowserCheckBox.Size = new System.Drawing.Size(160, 21);
            this.DefaultBrowserCheckBox.TabIndex = 22;
            this.DefaultBrowserCheckBox.Text = "Use browser default ";
            this.DefaultBrowserCheckBox.UseVisualStyleBackColor = true;
            this.DefaultBrowserCheckBox.CheckedChanged += new System.EventHandler(this.DefaultBrowserCheckBox_CheckedChanged);
            // 
            // UserAgentLabel
            // 
            this.UserAgentLabel.AutoSize = true;
            this.UserAgentLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserAgentLabel.Location = new System.Drawing.Point(23, 449);
            this.UserAgentLabel.Name = "UserAgentLabel";
            this.UserAgentLabel.Size = new System.Drawing.Size(78, 17);
            this.UserAgentLabel.TabIndex = 21;
            this.UserAgentLabel.Text = "User agent";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(12, 9);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(40, 17);
            this.URL.TabIndex = 23;
            this.URL.Text = "URL:";
            // 
            // userAgentInfoLabel
            // 
            this.userAgentInfoLabel.AutoSize = true;
            this.userAgentInfoLabel.Location = new System.Drawing.Point(159, 511);
            this.userAgentInfoLabel.Name = "userAgentInfoLabel";
            this.userAgentInfoLabel.Size = new System.Drawing.Size(152, 17);
            this.userAgentInfoLabel.TabIndex = 24;
            this.userAgentInfoLabel.Text = "User agent information";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(561, 545);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(89, 25);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // userAgentComboBox
            // 
            this.userAgentComboBox.FormattingEnabled = true;
            this.userAgentComboBox.Items.AddRange(new object[] {
            "Chrome - Windows",
            "Safari - Iphone",
            "Firefox - Windows"});
            this.userAgentComboBox.Location = new System.Drawing.Point(162, 472);
            this.userAgentComboBox.Name = "userAgentComboBox";
            this.userAgentComboBox.Size = new System.Drawing.Size(160, 24);
            this.userAgentComboBox.TabIndex = 26;
            this.userAgentComboBox.TextChanged += new System.EventHandler(this.userAgentComboBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 581);
            this.Controls.Add(this.userAgentComboBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.userAgentInfoLabel);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.DefaultBrowserCheckBox);
            this.Controls.Add(this.UserAgentLabel);
            this.Controls.Add(this.userAgentRichTextBox);
            this.Controls.Add(this.UserAgentButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.RenderTextBox);
            this.Controls.Add(this.RawTextBox);
            this.Controls.Add(this.HTMLTextBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.URITextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox URITextBox;
        private System.Windows.Forms.TextBox HTMLTextBox;
        private System.Windows.Forms.Button RawTextBox;
        private System.Windows.Forms.Button RenderTextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button UserAgentButton;
        private System.Windows.Forms.RichTextBox userAgentRichTextBox;
        private System.Windows.Forms.CheckBox DefaultBrowserCheckBox;
        private System.Windows.Forms.Label UserAgentLabel;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label userAgentInfoLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox userAgentComboBox;
    }
}

