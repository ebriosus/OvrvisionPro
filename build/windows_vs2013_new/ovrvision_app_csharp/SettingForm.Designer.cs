﻿namespace ovrvision_app
{
    partial class SettingForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExposure = new System.Windows.Forms.TrackBar();
            this.tboxExposure = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxGain = new System.Windows.Forms.TextBox();
            this.tboxWBRGain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWBRGain = new System.Windows.Forms.TrackBar();
            this.tboxWBGGain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWBGGain = new System.Windows.Forms.TrackBar();
            this.tboxWBBGain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWBBGain = new System.Windows.Forms.TrackBar();
            this.cbWBAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBRGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBGGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBBGain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(349, 250);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 30);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Close";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exposure (1 - 32767)";
            // 
            // tbExposure
            // 
            this.tbExposure.AutoSize = false;
            this.tbExposure.LargeChange = 1;
            this.tbExposure.Location = new System.Drawing.Point(14, 23);
            this.tbExposure.Maximum = 32767;
            this.tbExposure.Minimum = 1;
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(331, 21);
            this.tbExposure.TabIndex = 2;
            this.tbExposure.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbExposure.Value = 1;
            this.tbExposure.ValueChanged += new System.EventHandler(this.tbExposure_ValueChanged);
            // 
            // tboxExposure
            // 
            this.tboxExposure.Location = new System.Drawing.Point(351, 23);
            this.tboxExposure.MaxLength = 10;
            this.tboxExposure.Name = "tboxExposure";
            this.tboxExposure.ReadOnly = true;
            this.tboxExposure.Size = new System.Drawing.Size(94, 19);
            this.tboxExposure.TabIndex = 3;
            this.tboxExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGain
            // 
            this.tbGain.AutoSize = false;
            this.tbGain.LargeChange = 1;
            this.tbGain.Location = new System.Drawing.Point(14, 62);
            this.tbGain.Maximum = 47;
            this.tbGain.Minimum = 1;
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(331, 21);
            this.tbGain.TabIndex = 4;
            this.tbGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGain.Value = 1;
            this.tbGain.ValueChanged += new System.EventHandler(this.tbGain_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gain (1 - 47)";
            // 
            // tboxGain
            // 
            this.tboxGain.Location = new System.Drawing.Point(351, 62);
            this.tboxGain.MaxLength = 10;
            this.tboxGain.Name = "tboxGain";
            this.tboxGain.ReadOnly = true;
            this.tboxGain.Size = new System.Drawing.Size(94, 19);
            this.tboxGain.TabIndex = 6;
            this.tboxGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxWBRGain
            // 
            this.tboxWBRGain.Location = new System.Drawing.Point(349, 141);
            this.tboxWBRGain.MaxLength = 10;
            this.tboxWBRGain.Name = "tboxWBRGain";
            this.tboxWBRGain.ReadOnly = true;
            this.tboxWBRGain.Size = new System.Drawing.Size(94, 19);
            this.tboxWBRGain.TabIndex = 9;
            this.tboxWBRGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "White Balance R Gain (0 - 4095)";
            // 
            // tbWBRGain
            // 
            this.tbWBRGain.AutoSize = false;
            this.tbWBRGain.LargeChange = 1;
            this.tbWBRGain.Location = new System.Drawing.Point(12, 141);
            this.tbWBRGain.Maximum = 4095;
            this.tbWBRGain.Name = "tbWBRGain";
            this.tbWBRGain.Size = new System.Drawing.Size(331, 21);
            this.tbWBRGain.TabIndex = 7;
            this.tbWBRGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbWBRGain.ValueChanged += new System.EventHandler(this.tbWBRGain_ValueChanged);
            // 
            // tboxWBGGain
            // 
            this.tboxWBGGain.Location = new System.Drawing.Point(349, 177);
            this.tboxWBGGain.MaxLength = 10;
            this.tboxWBGGain.Name = "tboxWBGGain";
            this.tboxWBGGain.ReadOnly = true;
            this.tboxWBGGain.Size = new System.Drawing.Size(94, 19);
            this.tboxWBGGain.TabIndex = 12;
            this.tboxWBGGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "White Balance G Gain (0 - 4095)";
            // 
            // tbWBGGain
            // 
            this.tbWBGGain.AutoSize = false;
            this.tbWBGGain.LargeChange = 1;
            this.tbWBGGain.Location = new System.Drawing.Point(12, 177);
            this.tbWBGGain.Maximum = 4095;
            this.tbWBGGain.Name = "tbWBGGain";
            this.tbWBGGain.Size = new System.Drawing.Size(331, 21);
            this.tbWBGGain.TabIndex = 10;
            this.tbWBGGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbWBGGain.ValueChanged += new System.EventHandler(this.tbWBGGain_ValueChanged);
            // 
            // tboxWBBGain
            // 
            this.tboxWBBGain.Location = new System.Drawing.Point(349, 214);
            this.tboxWBBGain.MaxLength = 10;
            this.tboxWBBGain.Name = "tboxWBBGain";
            this.tboxWBBGain.ReadOnly = true;
            this.tboxWBBGain.Size = new System.Drawing.Size(94, 19);
            this.tboxWBBGain.TabIndex = 15;
            this.tboxWBBGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "White Balance B Gain (0 - 4095)";
            // 
            // tbWBBGain
            // 
            this.tbWBBGain.AutoSize = false;
            this.tbWBBGain.LargeChange = 1;
            this.tbWBBGain.Location = new System.Drawing.Point(12, 214);
            this.tbWBBGain.Maximum = 4095;
            this.tbWBBGain.Name = "tbWBBGain";
            this.tbWBBGain.Size = new System.Drawing.Size(331, 21);
            this.tbWBBGain.TabIndex = 13;
            this.tbWBBGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbWBBGain.ValueChanged += new System.EventHandler(this.tbWBBGain_ValueChanged);
            // 
            // cbWBAuto
            // 
            this.cbWBAuto.AutoSize = true;
            this.cbWBAuto.Location = new System.Drawing.Point(14, 102);
            this.cbWBAuto.Name = "cbWBAuto";
            this.cbWBAuto.Size = new System.Drawing.Size(152, 16);
            this.cbWBAuto.TabIndex = 17;
            this.cbWBAuto.Text = "White Balance Auto Gain";
            this.cbWBAuto.UseVisualStyleBackColor = true;
            this.cbWBAuto.CheckedChanged += new System.EventHandler(this.cbWBAuto_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 292);
            this.Controls.Add(this.cbWBAuto);
            this.Controls.Add(this.tboxWBBGain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWBBGain);
            this.Controls.Add(this.tboxWBGGain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWBGGain);
            this.Controls.Add(this.tboxWBRGain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWBRGain);
            this.Controls.Add(this.tboxGain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGain);
            this.Controls.Add(this.tboxExposure);
            this.Controls.Add(this.tbExposure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingForm";
            this.Text = "OvrvisionPro Camera Setting";
            ((System.ComponentModel.ISupportInitialize)(this.tbExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBRGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBGGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWBBGain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbExposure;
        private System.Windows.Forms.TextBox tboxExposure;
        private System.Windows.Forms.TrackBar tbGain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxGain;
        private System.Windows.Forms.TextBox tboxWBRGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbWBRGain;
        private System.Windows.Forms.TextBox tboxWBGGain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbWBGGain;
        private System.Windows.Forms.TextBox tboxWBBGain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbWBBGain;
        private System.Windows.Forms.CheckBox cbWBAuto;
    }
}