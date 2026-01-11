using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmDialog : Form
	{
		public class Alarms
		{
			public string Name { get; set; } = "Новый будильник";
			public TimeSpan Time { get; set; }
			public DateTime? Date { get; set; }
			public bool[] Days { get; set; } = new bool[7];
			public string Music { get; set; }
			public bool Enabled { get; set; } = true;

			public bool ShouldRing(DateTime now)
			{
				if (!Enabled) return false;
				if (now.TimeOfDay.Hours != Time.Hours || now.TimeOfDay.Minutes != Time.Minutes)
					return false;

				if (Date.HasValue) return now.Date == Date.Value.Date;
				if (Days.Any(d => d)) return Days[(int)now.DayOfWeek];
				return true;
			}
		}
		public Alarms Result { get; set; }

		public AlarmDialog(Alarms edit = null)
		{
			InitializeComponent();
			if (edit != null)
			{
				Result = edit;
			}
			else
			{
				Result = new Alarms();
			}

			string[] music = Directory.GetFiles("alarms", "*.mp3");
			comboBoxMusic.Items.AddRange(music.Select(Path.GetFileName).ToArray());
		}

		void LoadAlarms(Alarms alarms)
		{
			textName.Text = alarms.Name;
			TimePicker.Value = DateTime.Today.Add(alarms.Time);
			if(alarms.Date.HasValue)
				datePicker.Value = alarms.Date.Value;
			for (int i = 0; i < 7; i++)
				((CheckBox)panelDays.Controls[i]).Checked = alarms.Days[i];
			comboBoxMusic.Text = alarms.Music;
		}
	}
}
