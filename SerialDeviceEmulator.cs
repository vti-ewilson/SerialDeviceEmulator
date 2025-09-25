using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialDeviceManager.Forms;
using RamEmulator;

namespace SerialDeviceManager
{
	public partial class SerialDeviceEmulator : Form
	{
		private bool mouseDown = false;
		private Point lastLocation;

		public SerialDeviceEmulator()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TorrconFormButton_Click(object sender, EventArgs e)
		{
			Form tc = new TorrconEmulator.TorrconEmulator();
			tc.Show();
		}

		private void SMCFormButton_Click(object sender, EventArgs e)
		{
			Form smc = new SMCEmulator.SMCEmulatorForm();
			smc.Show();
		}

		private void SerialDeviceEmulator_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void SerialDeviceEmulator_MouseMove(object sender, MouseEventArgs e)
		{
			if(mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void SerialDeviceEmulator_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void scannerButton_Click(object sender, EventArgs e)
		{
			Form scan = new ScannerEmulator();
			scan.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form ram = new RamEmulatorForm();
			ram.Show();
		}

		private void LDS3000Button_Click(object sender, EventArgs e)
		{
			Form lds = new LDS3000Emulator();
			lds.Show();
		}
	}
}
