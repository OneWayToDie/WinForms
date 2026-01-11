namespace Clock
{
	partial class AlarmDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TimePicker = new System.Windows.Forms.DateTimePicker();
			this.checkDate = new System.Windows.Forms.CheckBox();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.panelDays = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxMusic = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название:";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(100, 7);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(200, 20);
			this.textName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Время:";
			// 
			// TimePicker
			// 
			this.TimePicker.Location = new System.Drawing.Point(100, 37);
			this.TimePicker.Name = "TimePicker";
			this.TimePicker.Size = new System.Drawing.Size(200, 20);
			this.TimePicker.TabIndex = 3;
			// 
			// checkDate
			// 
			this.checkDate.AutoSize = true;
			this.checkDate.Location = new System.Drawing.Point(10, 70);
			this.checkDate.Name = "checkDate";
			this.checkDate.Size = new System.Drawing.Size(68, 17);
			this.checkDate.TabIndex = 4;
			this.checkDate.Text = "На дату:";
			this.checkDate.UseVisualStyleBackColor = true;
			// 
			// datePicker
			// 
			this.datePicker.Location = new System.Drawing.Point(100, 67);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(200, 20);
			this.datePicker.TabIndex = 5;
			// 
			// panelDays
			// 
			this.panelDays.Location = new System.Drawing.Point(10, 100);
			this.panelDays.Name = "panelDays";
			this.panelDays.Size = new System.Drawing.Size(290, 30);
			this.panelDays.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Музыка:";
			// 
			// comboBoxMusic
			// 
			this.comboBoxMusic.FormattingEnabled = true;
			this.comboBoxMusic.Location = new System.Drawing.Point(100, 137);
			this.comboBoxMusic.Name = "comboBoxMusic";
			this.comboBoxMusic.Size = new System.Drawing.Size(200, 21);
			this.comboBoxMusic.TabIndex = 8;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(136, 415);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(230, 415);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// AlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 450);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.comboBoxMusic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panelDays);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.checkDate);
			this.Controls.Add(this.TimePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Name = "AlarmDialog";
			this.Text = "AlarmDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker TimePicker;
		private System.Windows.Forms.CheckBox checkDate;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Panel panelDays;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxMusic;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}