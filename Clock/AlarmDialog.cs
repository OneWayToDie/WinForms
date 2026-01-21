using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmDialog : Form
	{
		OpenFileDialog fileDialog;
		public Alarm Alarm { get; private set; }
		public AlarmDialog()
		{
			InitializeComponent();
			dtpDate.Enabled = false;
			fileDialog = new OpenFileDialog();
			fileDialog.Filter = "All sound files (*.mp3;*.flac;*.flacc;*.ape;*.wma)|*.mp3;*.flac;*.flacc;*.ape;*.wma" +
				"|mp3 files (*.mp3)|*.mp3" +
				"|Flac files (*.flac)|*.flac;*.flacc" +
				"|ape files (*.ape)|*.ape" +
				"|wma files (*.wma)|*.wma";
			Alarm = new Alarm();
			for (int i = 0; i < 7; i++)
				clbWeekdays.SetItemChecked(i, true);
		}
		public AlarmDialog(Alarm alarm) : this()
		{
			Alarm = alarm;
			Extract();
		}
		void Extract()
		{
			if (Alarm.Date != DateTime.MaxValue)
			{
				dtpDate.Value = Alarm.Date;
				checkBoxUseDate.Checked = true;
			}
			dtpTime.Value = DateTime.Now.Date + Alarm.Time;
			//if (checkBoxUseDate.Checked) Alarm.Days = new Week(0);
			Alarm.Days.Extract(clbWeekdays);
			labelFileName.Text = Alarm.Filename;
		}
		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = (sender as CheckBox).Checked;
			clbWeekdays.Enabled = !dtpDate.Enabled;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				labelFileName.Text = fileDialog.FileName;
			}
		}


		private void clbWeekdays_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < clbWeekdays.CheckedItems.Count; i++)
				Console.Write($"{clbWeekdays.CheckedItems[i]}\t");
			Console.WriteLine();
			byte days = 0;
			for (int i = 0; i < clbWeekdays.CheckedIndices.Count; i++)
			{
				days |= (byte)(1<<clbWeekdays.CheckedIndices[i]);
				Console.Write($"{clbWeekdays.CheckedIndices[i]}\t");
			}
			Console.WriteLine($"Days mask:{days}");
			Console.WriteLine("\n-------------------------------------------------\n");
		}
		byte GetDaysMask()
		{
			byte days = 0;
			for (int i = 0; i < clbWeekdays.CheckedIndices.Count; i++)
				days |= (byte)(1 << clbWeekdays.CheckedIndices[i]);
			return days;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			//if (clbWeekdays.CheckedIndices.Count == 0)
			//{
			//	MessageBox.Show(this, "Выберите хотя-бы один день недели", "Ёлки-Иголки", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//	return;
			//}
			Alarm.Date = checkBoxUseDate.Checked ? dtpDate.Value : DateTime.MaxValue;
			Alarm.Time = dtpTime.Value.TimeOfDay;
			Alarm.Days = new Week(GetDaysMask());
			//Alarm.Days = new Week(checkBoxUseDate.Checked ? (byte)0 : GetDaysMask());
			Alarm.Filename = labelFileName.Text;
		}
	}
}
