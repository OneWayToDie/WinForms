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
		private void ShowAlarmDialog()
		{
			using (AlarmDialog dialog = new AlarmDialog())
			{
				dialog.StartPosition = FormStartPosition.CenterParent;
				dialog.ShowDialog(this);
			}
		}
	}
}
