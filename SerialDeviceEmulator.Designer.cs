﻿namespace SerialDeviceManager
{
	partial class SerialDeviceEmulator
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
			if(disposing && (components != null))
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
			this.SMCFormButton = new System.Windows.Forms.Button();
			this.TorrconFormButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.scannerButton = new System.Windows.Forms.Button();
			this.TorrconLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SMCFormButton
			// 
			this.SMCFormButton.BackColor = System.Drawing.Color.Transparent;
			this.SMCFormButton.BackgroundImage = global::SerialDeviceManager.Properties.Resources.smcicon;
			this.SMCFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SMCFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SMCFormButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SMCFormButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SMCFormButton.Location = new System.Drawing.Point(466, 75);
			this.SMCFormButton.Name = "SMCFormButton";
			this.SMCFormButton.Size = new System.Drawing.Size(99, 131);
			this.SMCFormButton.TabIndex = 11;
			this.SMCFormButton.UseVisualStyleBackColor = false;
			this.SMCFormButton.Click += new System.EventHandler(this.SMCFormButton_Click);
			// 
			// TorrconFormButton
			// 
			this.TorrconFormButton.BackColor = System.Drawing.Color.Transparent;
			this.TorrconFormButton.BackgroundImage = global::SerialDeviceManager.Properties.Resources.tcemuicon2;
			this.TorrconFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TorrconFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.TorrconFormButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TorrconFormButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.TorrconFormButton.Location = new System.Drawing.Point(164, 85);
			this.TorrconFormButton.Name = "TorrconFormButton";
			this.TorrconFormButton.Size = new System.Drawing.Size(121, 121);
			this.TorrconFormButton.TabIndex = 10;
			this.TorrconFormButton.UseVisualStyleBackColor = false;
			this.TorrconFormButton.Click += new System.EventHandler(this.TorrconFormButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.Transparent;
			this.CloseButton.BackgroundImage = global::SerialDeviceManager.Properties.Resources.window_close_icon_512x506_ns6g3qrh;
			this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CloseButton.Location = new System.Drawing.Point(1239, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(40, 42);
			this.CloseButton.TabIndex = 9;
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// scannerButton
			// 
			this.scannerButton.BackColor = System.Drawing.Color.Transparent;
			this.scannerButton.BackgroundImage = global::SerialDeviceManager.Properties.Resources.ScannerIcon;
			this.scannerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.scannerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.scannerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scannerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.scannerButton.Location = new System.Drawing.Point(750, 75);
			this.scannerButton.Name = "scannerButton";
			this.scannerButton.Size = new System.Drawing.Size(89, 131);
			this.scannerButton.TabIndex = 12;
			this.scannerButton.UseVisualStyleBackColor = false;
			this.scannerButton.Click += new System.EventHandler(this.scannerButton_Click);
			// 
			// TorrconLabel
			// 
			this.TorrconLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TorrconLabel.Location = new System.Drawing.Point(164, 206);
			this.TorrconLabel.Name = "TorrconLabel";
			this.TorrconLabel.Size = new System.Drawing.Size(121, 43);
			this.TorrconLabel.TabIndex = 13;
			this.TorrconLabel.Text = "Torrcon";
			this.TorrconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(466, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 43);
			this.label1.TabIndex = 14;
			this.label1.Text = "SMC";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(726, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 43);
			this.label2.TabIndex = 15;
			this.label2.Text = "Scanner";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(982, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 43);
			this.label3.TabIndex = 17;
			this.label3.Text = "Ram";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(1006, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 131);
			this.button1.TabIndex = 16;
			this.button1.Text = "Ram";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SerialDeviceEmulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1291, 313);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TorrconLabel);
			this.Controls.Add(this.scannerButton);
			this.Controls.Add(this.SMCFormButton);
			this.Controls.Add(this.TorrconFormButton);
			this.Controls.Add(this.CloseButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SerialDeviceEmulator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SerialDeviceEmulator_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SerialDeviceEmulator_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SerialDeviceEmulator_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button TorrconFormButton;
		private System.Windows.Forms.Button SMCFormButton;
		private System.Windows.Forms.Button scannerButton;
		private System.Windows.Forms.Label TorrconLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}

