namespace Clock
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCustomFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundBlack = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundWhite = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundYellow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundGreen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundRed = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegroundBlue = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundBlack = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundWhite = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundYellow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundGreen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundRed = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundBlue = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAutoStart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.cbShowWeekday = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(13, 13);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(261, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiShowConsole,
            this.toolStripSeparator3,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator4,
            this.tsmiAlarms,
            this.toolStripSeparator5,
            this.tsmiAutoStart,
            this.toolStripSeparator6,
            this.tsmiQuit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 282);
			// 
			// tsmiTopmost
			// 
			this.tsmiTopmost.CheckOnClick = true;
			this.tsmiTopmost.Name = "tsmiTopmost";
			this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
			this.tsmiTopmost.Text = "Topmost";
			this.tsmiTopmost.Click += new System.EventHandler(this.tsmiTopmost_Click);
			// 
			// tsmiShowControls
			// 
			this.tsmiShowControls.CheckOnClick = true;
			this.tsmiShowControls.Name = "tsmiShowControls";
			this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowControls.Text = "Show controls";
			this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiShowDate
			// 
			this.tsmiShowDate.CheckOnClick = true;
			this.tsmiShowDate.Name = "tsmiShowDate";
			this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowDate.Text = "Show date";
			this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
			// 
			// tsmiShowWeekday
			// 
			this.tsmiShowWeekday.CheckOnClick = true;
			this.tsmiShowWeekday.Name = "tsmiShowWeekday";
			this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowWeekday.Text = "Show weekday";
			this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiShowConsole
			// 
			this.tsmiShowConsole.CheckOnClick = true;
			this.tsmiShowConsole.Name = "tsmiShowConsole";
			this.tsmiShowConsole.Size = new System.Drawing.Size(180, 22);
			this.tsmiShowConsole.Text = "Show console";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiFont
			// 
			this.tsmiFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomFont});
			this.tsmiFont.Name = "tsmiFont";
			this.tsmiFont.Size = new System.Drawing.Size(180, 22);
			this.tsmiFont.Text = "Font";
			// 
			// tsmiCustomFont
			// 
			this.tsmiCustomFont.Name = "tsmiCustomFont";
			this.tsmiCustomFont.Size = new System.Drawing.Size(180, 22);
			this.tsmiCustomFont.Text = "Custom Font";
			// 
			// tsmiColor
			// 
			this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
			this.tsmiColor.Name = "tsmiColor";
			this.tsmiColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiColor.Text = "Color";
			// 
			// tsmiForegroundColor
			// 
			this.tsmiForegroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundBlack,
            this.tsmiForegroundWhite,
            this.tsmiForegroundYellow,
            this.tsmiForegroundGreen,
            this.tsmiForegroundRed,
            this.tsmiForegroundBlue});
			this.tsmiForegroundColor.Name = "tsmiForegroundColor";
			this.tsmiForegroundColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundColor.Text = "Foreground color";
			// 
			// tsmiForegroundBlack
			// 
			this.tsmiForegroundBlack.CheckOnClick = true;
			this.tsmiForegroundBlack.Name = "tsmiForegroundBlack";
			this.tsmiForegroundBlack.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundBlack.Text = "Black";
			this.tsmiForegroundBlack.Click += new System.EventHandler(this.tsmiForegroundBlack_Click);
			// 
			// tsmiForegroundWhite
			// 
			this.tsmiForegroundWhite.CheckOnClick = true;
			this.tsmiForegroundWhite.Name = "tsmiForegroundWhite";
			this.tsmiForegroundWhite.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundWhite.Text = "White";
			this.tsmiForegroundWhite.Click += new System.EventHandler(this.tsmiForegroundWhite_Click);
			// 
			// tsmiForegroundYellow
			// 
			this.tsmiForegroundYellow.CheckOnClick = true;
			this.tsmiForegroundYellow.Name = "tsmiForegroundYellow";
			this.tsmiForegroundYellow.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundYellow.Text = "Yellow";
			this.tsmiForegroundYellow.Click += new System.EventHandler(this.tsmiForegroundYellow_Click);
			// 
			// tsmiForegroundGreen
			// 
			this.tsmiForegroundGreen.CheckOnClick = true;
			this.tsmiForegroundGreen.Name = "tsmiForegroundGreen";
			this.tsmiForegroundGreen.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundGreen.Text = "Green";
			this.tsmiForegroundGreen.Click += new System.EventHandler(this.tsmiForegroundGreen_Click);
			// 
			// tsmiForegroundRed
			// 
			this.tsmiForegroundRed.CheckOnClick = true;
			this.tsmiForegroundRed.Name = "tsmiForegroundRed";
			this.tsmiForegroundRed.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundRed.Text = "Red";
			this.tsmiForegroundRed.Click += new System.EventHandler(this.tsmiForegroundRed_Click);
			// 
			// tsmiForegroundBlue
			// 
			this.tsmiForegroundBlue.CheckOnClick = true;
			this.tsmiForegroundBlue.Name = "tsmiForegroundBlue";
			this.tsmiForegroundBlue.Size = new System.Drawing.Size(180, 22);
			this.tsmiForegroundBlue.Text = "Blue";
			this.tsmiForegroundBlue.Click += new System.EventHandler(this.tsmiForegroundBlue_Click);
			// 
			// tsmiBackgroundColor
			// 
			this.tsmiBackgroundColor.CheckOnClick = true;
			this.tsmiBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackgroundBlack,
            this.tsmiBackgroundWhite,
            this.tsmiBackgroundYellow,
            this.tsmiBackgroundGreen,
            this.tsmiBackgroundRed,
            this.tsmiBackgroundBlue});
			this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
			this.tsmiBackgroundColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundColor.Text = "Background color";
			// 
			// tsmiBackgroundBlack
			// 
			this.tsmiBackgroundBlack.Name = "tsmiBackgroundBlack";
			this.tsmiBackgroundBlack.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundBlack.Text = "Black";
			this.tsmiBackgroundBlack.Click += new System.EventHandler(this.tsmiBackgroundBlack_Click);
			// 
			// tsmiBackgroundWhite
			// 
			this.tsmiBackgroundWhite.CheckOnClick = true;
			this.tsmiBackgroundWhite.Name = "tsmiBackgroundWhite";
			this.tsmiBackgroundWhite.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundWhite.Text = "White";
			this.tsmiBackgroundWhite.Click += new System.EventHandler(this.tsmiBackgroundWhite_Click);
			// 
			// tsmiBackgroundYellow
			// 
			this.tsmiBackgroundYellow.CheckOnClick = true;
			this.tsmiBackgroundYellow.Name = "tsmiBackgroundYellow";
			this.tsmiBackgroundYellow.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundYellow.Text = "Yellow";
			this.tsmiBackgroundYellow.Click += new System.EventHandler(this.tsmiBackgroundYellow_Click);
			// 
			// tsmiBackgroundGreen
			// 
			this.tsmiBackgroundGreen.CheckOnClick = true;
			this.tsmiBackgroundGreen.Name = "tsmiBackgroundGreen";
			this.tsmiBackgroundGreen.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundGreen.Text = "Green";
			this.tsmiBackgroundGreen.Click += new System.EventHandler(this.tsmiBackgroundGreen_Click);
			// 
			// tsmiBackgroundRed
			// 
			this.tsmiBackgroundRed.CheckOnClick = true;
			this.tsmiBackgroundRed.Name = "tsmiBackgroundRed";
			this.tsmiBackgroundRed.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundRed.Text = "Red";
			this.tsmiBackgroundRed.Click += new System.EventHandler(this.tsmiBackgroundRed_Click);
			// 
			// tsmiBackgroundBlue
			// 
			this.tsmiBackgroundBlue.CheckOnClick = true;
			this.tsmiBackgroundBlue.Name = "tsmiBackgroundBlue";
			this.tsmiBackgroundBlue.Size = new System.Drawing.Size(180, 22);
			this.tsmiBackgroundBlue.Text = "Blue";
			this.tsmiBackgroundBlue.Click += new System.EventHandler(this.tsmiBackgroundBlue_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAlarms
			// 
			this.tsmiAlarms.Name = "tsmiAlarms";
			this.tsmiAlarms.Size = new System.Drawing.Size(180, 22);
			this.tsmiAlarms.Text = "Alarms";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiAutoStart
			// 
			this.tsmiAutoStart.CheckOnClick = true;
			this.tsmiAutoStart.Name = "tsmiAutoStart";
			this.tsmiAutoStart.Size = new System.Drawing.Size(180, 22);
			this.tsmiAutoStart.Text = "Auto start";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiQuit
			// 
			this.tsmiQuit.Name = "tsmiQuit";
			this.tsmiQuit.Size = new System.Drawing.Size(180, 22);
			this.tsmiQuit.Text = "Quit";
			this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(22, 193);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(176, 29);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Показать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
			// 
			// cbShowWeekday
			// 
			this.cbShowWeekday.AutoSize = true;
			this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowWeekday.Location = new System.Drawing.Point(22, 237);
			this.cbShowWeekday.Name = "cbShowWeekday";
			this.cbShowWeekday.Size = new System.Drawing.Size(256, 29);
			this.cbShowWeekday.TabIndex = 2;
			this.cbShowWeekday.Text = "Показать день недели";
			this.cbShowWeekday.UseVisualStyleBackColor = true;
			this.cbShowWeekday.CheckedChanged += new System.EventHandler(this.cbShowWeekday_CheckedChanged);
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(22, 273);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(252, 95);
			this.btnHideControls.TabIndex = 3;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "System tray";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(315, 450);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowWeekday);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Clock_PV_521";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.CheckBox cbShowWeekday;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowConsole;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem tsmiAutoStart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundBlack;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundWhite;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundYellow;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundGreen;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundRed;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegroundBlue;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundBlack;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundWhite;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundYellow;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundGreen;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundRed;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundBlue;
		private System.Windows.Forms.ToolStripMenuItem tsmiCustomFont;
	}
}

