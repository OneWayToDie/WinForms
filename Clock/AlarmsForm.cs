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
	public partial class AlarmsForm : Form
	{
		AlarmDialog alarm;
		public AlarmsForm()
		{
			InitializeComponent();
			alarm = new AlarmDialog();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(alarm.Alarm);
			}
		}

		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxAlarms.SelectedItem == null) return;

			Alarm selectedAlarm = listBoxAlarms.SelectedItem as Alarm;

			using (AlarmDialog editDialog = new AlarmDialog(selectedAlarm))
			{
				if (editDialog.ShowDialog() == DialogResult.OK)
				{
					int index = listBoxAlarms.SelectedIndex;
					listBoxAlarms.Items[index] = editDialog.Alarm;
				}
			}
		}
	}
}
