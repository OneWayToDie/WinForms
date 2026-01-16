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
		public AlarmDialog(Alarm alarm = null)
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
			Alarm.Date = checkBoxUseDate.Checked ? dtpDate.Value : DateTime.MaxValue;
			Alarm.Time = dtpTime.Value;
			Alarm.Days = new Week(GetDaysMask());
			Alarm.Filename = labelFileName.Text;
		}
	}
}
