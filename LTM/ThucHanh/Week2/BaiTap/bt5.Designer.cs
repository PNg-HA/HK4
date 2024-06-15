
namespace BaiTap
{
    partial class bt5
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
            this.BrowseBut = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.FolderDetailLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BrowseBut
            // 
            this.BrowseBut.Location = new System.Drawing.Point(551, 42);
            this.BrowseBut.Name = "BrowseBut";
            this.BrowseBut.Size = new System.Drawing.Size(75, 23);
            this.BrowseBut.TabIndex = 0;
            this.BrowseBut.Text = "Browse";
            this.BrowseBut.UseVisualStyleBackColor = true;
            this.BrowseBut.Click += new System.EventHandler(this.BrowseBut_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(148, 42);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(327, 22);
            this.urlTextBox.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(90, 43);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(41, 17);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path:";
            // 
            // FolderDetailLV
            // 
            this.FolderDetailLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FolderDetailLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.FolderDetailLV.FullRowSelect = true;
            this.FolderDetailLV.HideSelection = false;
            this.FolderDetailLV.HoverSelection = true;
            this.FolderDetailLV.Location = new System.Drawing.Point(37, 71);
            this.FolderDetailLV.Name = "FolderDetailLV";
            this.FolderDetailLV.Size = new System.Drawing.Size(600, 356);
            this.FolderDetailLV.TabIndex = 3;
            this.FolderDetailLV.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date created";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 100;
            // 
            // bt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FolderDetailLV);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.BrowseBut);
            this.Name = "bt5";
            this.Text = "bt5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseBut;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ListView FolderDetailLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}