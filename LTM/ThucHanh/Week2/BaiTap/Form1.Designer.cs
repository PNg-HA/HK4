
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
            this.bt1_but = new System.Windows.Forms.Button();
            this.bt2_but = new System.Windows.Forms.Button();
            this.bt3_but = new System.Windows.Forms.Button();
            this.bt5_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1_but
            // 
            this.bt1_but.Location = new System.Drawing.Point(106, 69);
            this.bt1_but.Name = "bt1_but";
            this.bt1_but.Size = new System.Drawing.Size(75, 23);
            this.bt1_but.TabIndex = 0;
            this.bt1_but.Text = "bai_1";
            this.bt1_but.UseVisualStyleBackColor = true;
            this.bt1_but.Click += new System.EventHandler(this.bt1_but_Click);
            // 
            // bt2_but
            // 
            this.bt2_but.Location = new System.Drawing.Point(537, 69);
            this.bt2_but.Name = "bt2_but";
            this.bt2_but.Size = new System.Drawing.Size(75, 23);
            this.bt2_but.TabIndex = 1;
            this.bt2_but.Text = "bai_2";
            this.bt2_but.UseVisualStyleBackColor = true;
            this.bt2_but.Click += new System.EventHandler(this.bt2_but_Click);
            // 
            // bt3_but
            // 
            this.bt3_but.Location = new System.Drawing.Point(106, 163);
            this.bt3_but.Name = "bt3_but";
            this.bt3_but.Size = new System.Drawing.Size(75, 23);
            this.bt3_but.TabIndex = 2;
            this.bt3_but.Text = "bai_3";
            this.bt3_but.UseVisualStyleBackColor = true;
            this.bt3_but.Click += new System.EventHandler(this.bt3_but_Click);
            // 
            // bt5_but
            // 
            this.bt5_but.Location = new System.Drawing.Point(537, 163);
            this.bt5_but.Name = "bt5_but";
            this.bt5_but.Size = new System.Drawing.Size(75, 23);
            this.bt5_but.TabIndex = 3;
            this.bt5_but.Text = "bai_5";
            this.bt5_but.UseVisualStyleBackColor = true;
            this.bt5_but.Click += new System.EventHandler(this.bt5_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt5_but);
            this.Controls.Add(this.bt3_but);
            this.Controls.Add(this.bt2_but);
            this.Controls.Add(this.bt1_but);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1_but;
        private System.Windows.Forms.Button bt2_but;
        private System.Windows.Forms.Button bt3_but;
        private System.Windows.Forms.Button bt5_but;
    }
}

