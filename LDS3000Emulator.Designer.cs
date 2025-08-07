namespace SerialDeviceManager.Forms
{
	partial class LDS3000Emulator
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
			this.leakRateSlider = new System.Windows.Forms.TrackBar();
			this.headerLabel = new System.Windows.Forms.Label();
			this.connectButton = new System.Windows.Forms.Button();
			this.disconnectButton = new System.Windows.Forms.Button();
			this.COMPortDropdown = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.gaugeTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.leakRateLabel = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pressLabel2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.SetButton = new System.Windows.Forms.Button();
			this.pressInputBox = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.leakRateSlider)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.gaugeTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// leakRateSlider
			// 
			this.leakRateSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.leakRateSlider.Location = new System.Drawing.Point(78, 30);
			this.leakRateSlider.Maximum = 0;
			this.leakRateSlider.Minimum = -1000;
			this.leakRateSlider.Name = "leakRateSlider";
			this.leakRateSlider.Size = new System.Drawing.Size(552, 69);
			this.leakRateSlider.TabIndex = 0;
			this.leakRateSlider.Scroll += new System.EventHandler(this.leakRateSlider_Scroll);
			// 
			// headerLabel
			// 
			this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.headerLabel.Location = new System.Drawing.Point(173, 9);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(337, 40);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "LDS3000 Emulator";
			// 
			// connectButton
			// 
			this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectButton.Location = new System.Drawing.Point(59, 182);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(169, 53);
			this.connectButton.TabIndex = 2;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// disconnectButton
			// 
			this.disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.disconnectButton.Location = new System.Drawing.Point(470, 182);
			this.disconnectButton.Name = "disconnectButton";
			this.disconnectButton.Size = new System.Drawing.Size(179, 53);
			this.disconnectButton.TabIndex = 3;
			this.disconnectButton.Text = "Disconnect";
			this.disconnectButton.UseVisualStyleBackColor = true;
			this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
			// 
			// COMPortDropdown
			// 
			this.COMPortDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.COMPortDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.COMPortDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COMPortDropdown.FormattingEnabled = true;
			this.COMPortDropdown.Location = new System.Drawing.Point(284, 191);
			this.COMPortDropdown.Name = "COMPortDropdown";
			this.COMPortDropdown.Size = new System.Drawing.Size(131, 37);
			this.COMPortDropdown.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(49, 53);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(624, 236);
			this.panel2.TabIndex = 6;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Gainsboro;
			this.panel6.Controls.Add(this.gaugeTabControl);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(10, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(604, 216);
			this.panel6.TabIndex = 0;
			// 
			// gaugeTabControl
			// 
			this.gaugeTabControl.Controls.Add(this.tabPage1);
			this.gaugeTabControl.Controls.Add(this.tabPage2);
			this.gaugeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gaugeTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gaugeTabControl.Location = new System.Drawing.Point(0, 0);
			this.gaugeTabControl.Name = "gaugeTabControl";
			this.gaugeTabControl.SelectedIndex = 0;
			this.gaugeTabControl.Size = new System.Drawing.Size(604, 216);
			this.gaugeTabControl.TabIndex = 0;
			this.gaugeTabControl.SelectedIndexChanged += new System.EventHandler(this.gaugeTabControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.leakRateLabel);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 38);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(596, 174);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Gauge 1";
			// 
			// leakRateLabel
			// 
			this.leakRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leakRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.leakRateLabel.Location = new System.Drawing.Point(3, 3);
			this.leakRateLabel.Name = "leakRateLabel";
			this.leakRateLabel.Size = new System.Drawing.Size(590, 168);
			this.leakRateLabel.TabIndex = 0;
			this.leakRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.pressLabel2);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage2.Location = new System.Drawing.Point(4, 38);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(596, 278);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Gauge 2";
			// 
			// pressLabel2
			// 
			this.pressLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pressLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pressLabel2.Location = new System.Drawing.Point(3, 3);
			this.pressLabel2.Name = "pressLabel2";
			this.pressLabel2.Size = new System.Drawing.Size(590, 272);
			this.pressLabel2.TabIndex = 1;
			this.pressLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.headerLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(722, 53);
			this.panel1.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.SetButton);
			this.panel3.Controls.Add(this.pressInputBox);
			this.panel3.Controls.Add(this.leakRateSlider);
			this.panel3.Controls.Add(this.connectButton);
			this.panel3.Controls.Add(this.disconnectButton);
			this.panel3.Controls.Add(this.COMPortDropdown);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 289);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(722, 277);
			this.panel3.TabIndex = 8;
			// 
			// SetButton
			// 
			this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SetButton.Location = new System.Drawing.Point(369, 105);
			this.SetButton.Name = "SetButton";
			this.SetButton.Size = new System.Drawing.Size(97, 39);
			this.SetButton.TabIndex = 10;
			this.SetButton.Text = "Set";
			this.SetButton.UseVisualStyleBackColor = true;
			this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
			// 
			// pressInputBox
			// 
			this.pressInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pressInputBox.Location = new System.Drawing.Point(187, 105);
			this.pressInputBox.Name = "pressInputBox";
			this.pressInputBox.Size = new System.Drawing.Size(150, 39);
			this.pressInputBox.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(673, 53);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(49, 236);
			this.panel4.TabIndex = 9;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 53);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(49, 236);
			this.panel5.TabIndex = 10;
			// 
			// LDS3000Emulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(722, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "LDS3000Emulator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LDS3000Emulator_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.leakRateSlider)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.gaugeTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar leakRateSlider;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Button disconnectButton;
		private System.Windows.Forms.ComboBox COMPortDropdown;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button SetButton;
		private System.Windows.Forms.TextBox pressInputBox;
		private System.Windows.Forms.TabControl gaugeTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label leakRateLabel;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label pressLabel2;
	}
}

