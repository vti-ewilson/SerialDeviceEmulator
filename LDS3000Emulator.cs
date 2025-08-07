using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialDeviceManager.Forms
{
	public partial class LDS3000Emulator : Form
	{
		SerialPort port;
        System.Threading.Thread comThread;
		bool disconnectClicked = false;
		double leakRateValue;

		public LDS3000Emulator()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connectButton.Enabled = true;
			disconnectButton.Enabled = false;
			populateComPortMenu();
			leakRateValue = GetSliderValue();
			SetPressLabel();
		}

		private void SetPressLabel()
		{
			leakRateLabel.Text = leakRateValue.ToString("E3") + " atm*cc/sec";
		}

		private double GetSliderValue()
		{
			double logValue = Math.Pow(10, (double)leakRateSlider.Value / 100f);
			return logValue;
		}

		private string GetDropdownValue()
		{
			if(COMPortDropdown.SelectedItem != null)
				return COMPortDropdown.SelectedItem.ToString();
			else
				return "";
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
			port = new SerialPort(portName, 9600);
			port.Open();
			byte[] buffer;
			string recd, msg;
			while(!disconnectClicked)
			{
				int count = port.BytesToRead;
				if(count >= 2)
				{
					buffer = new byte[count];
					var str = port.Read(buffer, 0, count);
					recd = Encoding.Default.GetString(buffer);
					Console.WriteLine(recd);
					if(recd.Contains("*p"))
					{
						msg = "p1 " + leakRateValue.ToString();
					}
					else if(recd.Contains("*v"))
					{
						double sliderVal = 0;
						sliderVal = leakRateValue;
						double sliderVal2 = 0;
						msg = "p1 " + sliderVal.ToString() + ":p2 " + sliderVal2.ToString();
					}
					else if(recd.Contains("p"))
					{
						msg = leakRateValue.ToString();
					}
					else
					{
						msg = "error";
					}
					port.WriteLine(msg);
					Console.WriteLine(msg);
				}
				else
				{
					Console.WriteLine("here");
					Thread.Sleep(100);
				}
			}
			disconnectClicked = false;
			port.Close();
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

		private void populateComPortMenu()
		{
			COMPortDropdown.Items.AddRange(
			        System.IO.Ports.SerialPort.GetPortNames()
			            .OrderBy(s => s)
			            .Distinct()
			            .ToArray());
		}

		private void leakRateSlider_Scroll(object sender, EventArgs e)
		{
			leakRateValue = GetSliderValue();
			SetPressLabel();
		}

		private void SetButton_Click(object sender, EventArgs e)
		{
			if(Double.TryParse(pressInputBox.Text, out leakRateValue))
			{
				double exponent = Math.Log10(leakRateValue);  // Get base-10 exponent
				int sliderPosition = (int)Math.Round(exponent * 100); // Convert to slider scale

				if(sliderPosition <= leakRateSlider.Maximum && sliderPosition >= leakRateSlider.Minimum)
				{
					leakRateSlider.Value = sliderPosition;
				}
				SetPressLabel();
			}
		}

		private void LDS3000Emulator_FormClosed(object sender, FormClosedEventArgs e)
		{
			disconnectClicked = true;
			if(comThread != null) comThread.Join();
		}

		private void gaugeTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			leakRateSlider.Value = (int)leakRateValue;
		}
	}
}
