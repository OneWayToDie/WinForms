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
		public class Alarm
		{
			public string Name { get; set; } = "Новый будильник";
			public TimeSpan Time { get; set; }
			public DateTime Date { get; set; }
			public bool[] Days { get; set; } = new bool[7];
			public string Music { get; set; }
			public bool Enabled { get; set; } = true;
		}
		public Alarm Result { get; set; }

		public AlarmDialog(Alarm edit = null)
		{
			InitializeComponent();
			if (edit != null)
			{
				Result = edit;
			}
			else
			{
				Result = new Alarm();
			}

			string[] music = Directory.GetFiles("alarms", "*.mp3");
			comboBoxMusic.Items.AddRange(music.Select(Path.GetFileName).ToArray());
		}

		void LoadAlarms(Alarm alarms)
		{
			textName.Text = alarms.Name;
			TimePicker.Value = DateTime.Today.Add(alarms.Time);
			for (int i = 0; i < 7; i++)
				((CheckBox)panelDays.Controls[i]).Checked = alarms.Days[i];
			comboBoxMusic.Text = alarms.Music;
		}
	}
}
