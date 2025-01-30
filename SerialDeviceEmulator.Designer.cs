namespace SerialDeviceManager
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
			this.SMCFormButton.Location = new System.Drawing.Point(629, 85);
			this.SMCFormButton.Name = "SMCFormButton";
			this.SMCFormButton.Size = new System.Drawing.Size(89, 131);
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
			this.TorrconFormButton.Location = new System.Drawing.Point(295, 85);
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
			this.CloseButton.Location = new System.Drawing.Point(967, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(40, 42);
			this.CloseButton.TabIndex = 9;
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// SerialDeviceEmulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1019, 313);
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
	}
}

