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
	public partial class MainForm : Form
	{

		private ContextMenuStrip contextMenuClock;
		public MainForm()
		{
			InitializeComponent();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			InitializeContextMenu();
		}
		private void InitializeContextMenu()
		{
			ContextMenuStrip clockMenu = new ContextMenuStrip();
			clockMenu.Items.Add("Показать/скрыть панель", null, (s, e) =>
			{
				bool currentVisibility = cbShowDate.Visible;
				SetVisibility(!currentVisibility);
			});
			clockMenu.Items.Add("Поверх всех окон", null, (s, e) =>
			{
				this.TopMost = !this.TopMost;
			});
			clockMenu.Items.Add("Выход", null, (s, e) => Application.Exit());
			labelTime.ContextMenuStrip = clockMenu;


			ContextMenuStrip trayMenu = new ContextMenuStrip();
			trayMenu.Items.Add("Открыть", null, (s, e) =>
			{
				SetVisibility(true);
				this.Show();
			});
			trayMenu.Items.Add("Скрыть", null, (s, e) => SetVisibility(false));
			trayMenu.Items.Add("Выход", null, (s, e) => Application.Exit());

			notifyIcon.ContextMenuStrip = trayMenu;

		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekday.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				"HH:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if (cbShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (cbShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
		
			notifyIcon.Text = labelTime.Text ;
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(false);
		}

		private void labelTime_MouseHover(object sender, EventArgs e)
		{
			SetVisibility(true);
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.TopMost = true;
			this.TopMost = false;
		}
		//3. Часы должны запускаться в правом верхнем углу, независимо от размеров экрана;
		//Layout, location x = 1595, y = 0
		//Start Position = Manual
	}
}
