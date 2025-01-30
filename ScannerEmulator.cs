using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDeviceManager.Forms
{
	public partial class ScannerEmulator : Form
	{
		SerialPort port;
		System.Threading.Thread comThread;
		bool disconnectClicked = false;
		bool scanClicked = false;
		string scannerText = "";

		public ScannerEmulator()
		{
			InitializeComponent();
		}

		private void populateComPortMenu()
		{
			COMPortDropdown.Items.AddRange(
					System.IO.Ports.SerialPort.GetPortNames()
						.OrderBy(s => s)
						.Distinct()
						.ToArray());
		}

		private void ScannerEmulator_Load(object sender, EventArgs e)
		{
			populateComPortMenu();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			SetButtonStates(true);

			comThread = new Thread(() => communicate());
			comThread.Start();
		}

		private void disconnectButton_Click(object sender, EventArgs e)
		{
			SetButtonStates(false);
			disconnectClicked = true;
		}

		private void SetButtonStates(bool connected)
		{
			if(connected)
			{
				connectButton.Enabled = false;
				disconnectButton.Enabled = true;
				connectButton.BackColor = Color.LightGreen;
				disconnectButton.BackColor = Color.White;
			}
			else
			{
				connectButton.Enabled = true;
				disconnectButton.Enabled = false;
				disconnectButton.BackColor = Color.Red;
				connectButton.BackColor = Color.White;
			}

		}

		private void communicate()
		{
			string portName = (string)COMPortDropdown.Invoke(new Func<string>(() => GetDropdownValue()));
			if(portName == "")
			{
				connectButton.Invoke(new Action(() => SetButtonStates(false)));
				return;
			}
			port = new SerialPort(portName, 19200);
			port.Open();
			while(!disconnectClicked)
			{
				if(scanClicked)
				{
					port.WriteLine(scannerText);
					Console.WriteLine(scannerText);
					scanClicked = false;
				}
				Thread.Sleep(100);
			}
			disconnectClicked = false;
			port.Close();
		}
		private string GetDropdownValue()
		{
			if(COMPortDropdown.SelectedItem != null)
				return COMPortDropdown.SelectedItem.ToString();
			else
				return "";
		}

		private void ScanButton_Click(object sender, EventArgs e)
		{
			if(ScannerTextBox.Text != "")
			{
				scannerText = ScannerTextBox.Text + "\r\n";
				ScannerTextBox.Text = "";
				scanClicked = true;
			}
		}
	}
}
