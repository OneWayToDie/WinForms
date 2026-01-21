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
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
			StreamWriter writer = new StreamWriter("Alarm.ini");
			foreach (Alarm alarm in listBoxAlarms.Items)
			{
				writer.WriteLine(alarm.ToString());
			}
			writer.Close();
			System.Diagnostics.Process.Start("notepad", "Alarm.ini");
		}
		void LoadAlarms()
		{
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");

			try
			{
				StreamReader reader = new StreamReader("Alarm.ini");

				listBoxAlarms.Items.Clear();

				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					if (string.IsNullOrEmpty(line)) continue;

					// Разделяем по табуляции
					string[] parts = line.Split('\t');
					if (parts.Length < 4) continue;

					Alarm alarm = new Alarm();

					// 1. Дата (parts[0])
					if (parts[0] == "Каждый день")
						alarm.Date = DateTime.MaxValue;
					else
						alarm.Date = DateTime.ParseExact(parts[0], "yyyy.MM.dd", null);

					// 2. Время (parts[1]) - формат HH:mm:ss
					string timeStr = parts[1];
					// Убираем дату если есть (берем только время)
					if (timeStr.Contains(' '))
						timeStr = timeStr.Split(' ')[1];
					alarm.Time = TimeSpan.Parse(timeStr);

					// 3. Дни недели (parts[2]) - строка типа "Пн,Вт,Ср,"
					string daysStr = parts[2].TrimEnd(',');
					byte daysByte = 0;
					string[] dayParts = daysStr.Split(',');

					foreach (string day in dayParts)
					{
						if (!string.IsNullOrEmpty(day))
						{
							// Находим индекс дня в NAMES
							int index = Array.IndexOf(Week.NAMES, day);
							if (index >= 0)
							{
								daysByte |= (byte)(1 << index);
							}
						}
					}
					alarm.Days = new Week(daysByte);

					// 4. Имя файла (parts[3])
					alarm.Filename = parts[3];

					listBoxAlarms.Items.Add(alarm);
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка загрузки будильников: {ex.Message}",
							   "Alarms issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
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
