using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		//AlarmDialog alarm;
		public ListBox List { get => listBoxAlarms; }
		public AlarmsForm()
		{
			InitializeComponent();
			//alarm = new AlarmDialog();
			LoadAlarms();
		}
		void SaveAlarms()
		{
			//Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
			//StreamWriter writer = new StreamWriter("Alarm.ini");
			//foreach (Alarm alarm in listBoxAlarms.Items)
			//{
			//	writer.WriteLine(alarm.ToString());
			//	//DateTime alarmDateTime = alarm.Date.Date.Add(alarm.Time);
			//}
			//writer.Close();
			//System.Diagnostics.Process.Start("notepad", "Alarm.ini");
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
			using (StreamWriter writer = new StreamWriter("Alarm.ini"))
			{
				foreach (Alarm alarm in listBoxAlarms.Items)
				{
					string dateStr = alarm.Date == DateTime.MaxValue ? "Каждый день" : alarm.Date.ToString("yyyy.MM.dd");
					writer.WriteLine($"{dateStr}|{alarm.Time}|{alarm.Days}|{alarm.Filename}");
				}
			}
			System.Diagnostics.Process.Start("notepad", "Alarm.ini");
		}
		void LoadAlarms()
		{
			
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AlarmDialog alarm = new AlarmDialog();
			if (alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
			}
		}

		private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItem != null)
			{
				AlarmDialog alarm = new AlarmDialog(listBoxAlarms.SelectedItem as Alarm);
				alarm.ShowDialog();
				listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = new Alarm(alarm.Alarm);
			}
			else 
			{
				buttonAdd_Click(sender, e);
			}
		}

		private void AlarmsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveAlarms();
		}
	}
}
