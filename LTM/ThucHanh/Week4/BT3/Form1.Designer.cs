
namespace Weather_App
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
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SearchBut = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.SrLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(51, 34);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(51, 29);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.Location = new System.Drawing.Point(119, 31);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(208, 36);
            this.CityTextBox.TabIndex = 1;
            // 
            // SearchBut
            // 
            this.SearchBut.BackColor = System.Drawing.Color.Transparent;
            this.SearchBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut.ForeColor = System.Drawing.Color.White;
            this.SearchBut.Location = new System.Drawing.Point(350, 34);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(78, 33);
            this.SearchBut.TabIndex = 2;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(52, 161);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(111, 29);
            this.ConditionLabel.TabIndex = 3;
            this.ConditionLabel.Text = "Condition";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.BackColor = System.Drawing.Color.Transparent;
            this.HLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLabel.Location = new System.Drawing.Point(57, 301);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(112, 29);
            this.HLabel.TabIndex = 4;
            this.HLabel.Text = "Humidity:";
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetailLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabel.Location = new System.Drawing.Point(52, 204);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(82, 29);
            this.DetailLabel.TabIndex = 4;
            this.DetailLabel.Text = "Details";
            // 
            // SrLabel
            // 
            this.SrLabel.AutoSize = true;
            this.SrLabel.BackColor = System.Drawing.Color.Transparent;
            this.SrLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrLabel.Location = new System.Drawing.Point(52, 260);
            this.SrLabel.Name = "SrLabel";
            this.SrLabel.Size = new System.Drawing.Size(149, 29);
            this.SrLabel.TabIndex = 5;
            this.SrLabel.Text = "Temperature:";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.BackColor = System.Drawing.Color.Transparent;
            this.WLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLabel.Location = new System.Drawing.Point(393, 136);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(92, 29);
            this.WLabel.TabIndex = 6;
            this.WLabel.Text = "Sức gió:";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.BackColor = System.Drawing.Color.Transparent;
            this.PLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLabel.Location = new System.Drawing.Point(394, 180);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(108, 29);
            this.PLabel.TabIndex = 7;
            this.PLabel.Text = "Pressure:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(57, 84);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.TabIndex = 8;
            this.picIcon.TabStop = false;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.Location = new System.Drawing.Point(215, 260);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(53, 29);
            this.TempLabel.TabIndex = 9;
            this.TempLabel.Text = "N/A";
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindLabel.Location = new System.Drawing.Point(540, 136);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(53, 29);
            this.WindLabel.TabIndex = 10;
            this.WindLabel.Text = "N/A";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureLabel.Location = new System.Drawing.Point(540, 180);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(53, 29);
            this.PressureLabel.TabIndex = 11;
            this.PressureLabel.Text = "N/A";
            // 
            // HumidLabel
            // 
            this.HumidLabel.AutoSize = true;
            this.HumidLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidLabel.Location = new System.Drawing.Point(215, 301);
            this.HumidLabel.Name = "HumidLabel";
            this.HumidLabel.Size = new System.Drawing.Size(53, 29);
            this.HumidLabel.TabIndex = 12;
            this.HumidLabel.Text = "N/A";
            this.HumidLabel.Click += new System.EventHandler(this.SunsetLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_App.Properties.Resources.mvehfqz6w2ges2dj1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(731, 462);
            this.Controls.Add(this.HumidLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.WindLabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.SrLabel);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.Label SrLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidLabel;
    }
}

