namespace SerialDeviceManager.Forms
{
	partial class ScannerEmulator
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
			this.ScannerTextBox = new System.Windows.Forms.TextBox();
			this.ScanButton = new System.Windows.Forms.Button();
			this.disconnectButton = new System.Windows.Forms.Button();
			this.connectButton = new System.Windows.Forms.Button();
			this.COMPortDropdown = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ScannerTextBox
			// 
			this.ScannerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScannerTextBox.Location = new System.Drawing.Point(121, 125);
			this.ScannerTextBox.Name = "ScannerTextBox";
			this.ScannerTextBox.Size = new System.Drawing.Size(364, 44);
			this.ScannerTextBox.TabIndex = 0;
			// 
			// ScanButton
			// 
			this.ScanButton.BackColor = System.Drawing.Color.LawnGreen;
			this.ScanButton.BackgroundImage = global::SerialDeviceManager.Properties.Resources.MISC25;
			this.ScanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScanButton.Location = new System.Drawing.Point(537, 98);
			this.ScanButton.Name = "ScanButton";
			this.ScanButton.Size = new System.Drawing.Size(143, 100);
			this.ScanButton.TabIndex = 1;
			this.ScanButton.Text = "Scan";
			this.ScanButton.UseVisualStyleBackColor = false;
			this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
			// 
			// disconnectButton
			// 
			this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disconnectButton.Location = new System.Drawing.Point(530, 297);
			this.disconnectButton.Name = "disconnectButton";
			this.disconnectButton.Size = new System.Drawing.Size(150, 68);
			this.disconnectButton.TabIndex = 5;
			this.disconnectButton.Text = "Disconnect";
			this.disconnectButton.UseVisualStyleBackColor = true;
			this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
			// 
			// connectButton
			// 
			this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectButton.Location = new System.Drawing.Point(121, 297);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(150, 68);
			this.connectButton.TabIndex = 4;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// COMPortDropdown
			// 
			this.COMPortDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.COMPortDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COMPortDropdown.FormattingEnabled = true;
			this.COMPortDropdown.Location = new System.Drawing.Point(331, 308);
			this.COMPortDropdown.Name = "COMPortDropdown";
			this.COMPortDropdown.Size = new System.Drawing.Size(144, 40);
			this.COMPortDropdown.TabIndex = 3;
			// 
			// ScannerEmulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.disconnectButton);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.COMPortDropdown);
			this.Controls.Add(this.ScanButton);
			this.Controls.Add(this.ScannerTextBox);
			this.Name = "ScannerEmulator";
			this.Text = "ScannerEmulator";
			this.Load += new System.EventHandler(this.ScannerEmulator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ScannerTextBox;
		private System.Windows.Forms.Button ScanButton;
		private System.Windows.Forms.Button disconnectButton;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.ComboBox COMPortDropdown;
	}
}