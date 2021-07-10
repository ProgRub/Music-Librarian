
namespace Forms
{
	partial class SetAlbumPropertiesScreen
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonGetPossibleAlbums = new System.Windows.Forms.Button();
			this.LabelAlbumTime = new System.Windows.Forms.Label();
			this.DateTimePickerAlbumTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.LabelTimeLeeway = new System.Windows.Forms.Label();
			this.CheckBoxSelectAll = new System.Windows.Forms.CheckBox();
			this.ButtonChooseWorkout = new System.Windows.Forms.Button();
			this.ComboBoxWorkouts = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ButtonGetPossibleAlbums
			// 
			this.ButtonGetPossibleAlbums.AutoSize = true;
			this.ButtonGetPossibleAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonGetPossibleAlbums.BackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.BorderSize = 0;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGetPossibleAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonGetPossibleAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonGetPossibleAlbums.Location = new System.Drawing.Point(199, 112);
			this.ButtonGetPossibleAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonGetPossibleAlbums.Name = "ButtonGetPossibleAlbums";
			this.ButtonGetPossibleAlbums.Size = new System.Drawing.Size(174, 27);
			this.ButtonGetPossibleAlbums.TabIndex = 10;
			this.ButtonGetPossibleAlbums.Text = "Get Possible Albums";
			this.ButtonGetPossibleAlbums.UseVisualStyleBackColor = false;
			this.ButtonGetPossibleAlbums.Click += new System.EventHandler(this.ButtonGetPossibleAlbums_Click);
			// 
			// LabelAlbumTime
			// 
			this.LabelAlbumTime.AutoSize = true;
			this.LabelAlbumTime.Location = new System.Drawing.Point(126, 46);
			this.LabelAlbumTime.Name = "LabelAlbumTime";
			this.LabelAlbumTime.Size = new System.Drawing.Size(105, 17);
			this.LabelAlbumTime.TabIndex = 18;
			this.LabelAlbumTime.Text = "Album Time:";
			// 
			// DateTimePickerAlbumTime
			// 
			this.DateTimePickerAlbumTime.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerAlbumTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.DateTimePickerAlbumTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CustomFormat = "HH:mm";
			this.DateTimePickerAlbumTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerAlbumTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerAlbumTime.Location = new System.Drawing.Point(237, 40);
			this.DateTimePickerAlbumTime.Name = "DateTimePickerAlbumTime";
			this.DateTimePickerAlbumTime.ShowUpDown = true;
			this.DateTimePickerAlbumTime.Size = new System.Drawing.Size(107, 24);
			this.DateTimePickerAlbumTime.TabIndex = 19;
			this.DateTimePickerAlbumTime.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.dateTimePicker1.CustomFormat = "HH:mm";
			this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(237, 70);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(107, 24);
			this.dateTimePicker1.TabIndex = 21;
			this.dateTimePicker1.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
			// 
			// LabelTimeLeeway
			// 
			this.LabelTimeLeeway.AutoSize = true;
			this.LabelTimeLeeway.Location = new System.Drawing.Point(158, 76);
			this.LabelTimeLeeway.Name = "LabelTimeLeeway";
			this.LabelTimeLeeway.Size = new System.Drawing.Size(73, 17);
			this.LabelTimeLeeway.TabIndex = 20;
			this.LabelTimeLeeway.Text = "Leeway:";
			// 
			// CheckBoxSelectAll
			// 
			this.CheckBoxSelectAll.AutoSize = true;
			this.CheckBoxSelectAll.Location = new System.Drawing.Point(19, 112);
			this.CheckBoxSelectAll.Name = "CheckBoxSelectAll";
			this.CheckBoxSelectAll.Size = new System.Drawing.Size(97, 21);
			this.CheckBoxSelectAll.TabIndex = 22;
			this.CheckBoxSelectAll.Text = "Select All";
			this.CheckBoxSelectAll.UseVisualStyleBackColor = true;
			// 
			// ButtonChooseWorkout
			// 
			this.ButtonChooseWorkout.AutoSize = true;
			this.ButtonChooseWorkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseWorkout.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseWorkout.FlatAppearance.BorderSize = 0;
			this.ButtonChooseWorkout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseWorkout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseWorkout.Location = new System.Drawing.Point(419, 40);
			this.ButtonChooseWorkout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonChooseWorkout.Name = "ButtonChooseWorkout";
			this.ButtonChooseWorkout.Size = new System.Drawing.Size(149, 27);
			this.ButtonChooseWorkout.TabIndex = 23;
			this.ButtonChooseWorkout.Text = "Choose Workout";
			this.ButtonChooseWorkout.UseVisualStyleBackColor = false;
			this.ButtonChooseWorkout.Click += new System.EventHandler(this.ButtonChooseWorkout_Click);
			// 
			// ComboBoxWorkouts
			// 
			this.ComboBoxWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ComboBoxWorkouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxWorkouts.Enabled = false;
			this.ComboBoxWorkouts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ComboBoxWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxWorkouts.FormattingEnabled = true;
			this.ComboBoxWorkouts.Location = new System.Drawing.Point(419, 69);
			this.ComboBoxWorkouts.Name = "ComboBoxWorkouts";
			this.ComboBoxWorkouts.Size = new System.Drawing.Size(312, 24);
			this.ComboBoxWorkouts.TabIndex = 24;
			// 
			// SetAlbumPropertiesScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ComboBoxWorkouts);
			this.Controls.Add(this.ButtonChooseWorkout);
			this.Controls.Add(this.CheckBoxSelectAll);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.LabelTimeLeeway);
			this.Controls.Add(this.DateTimePickerAlbumTime);
			this.Controls.Add(this.LabelAlbumTime);
			this.Controls.Add(this.ButtonGetPossibleAlbums);
			this.Name = "SetAlbumPropertiesScreen";
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ButtonGetPossibleAlbums, 0);
			this.Controls.SetChildIndex(this.LabelAlbumTime, 0);
			this.Controls.SetChildIndex(this.DateTimePickerAlbumTime, 0);
			this.Controls.SetChildIndex(this.LabelTimeLeeway, 0);
			this.Controls.SetChildIndex(this.dateTimePicker1, 0);
			this.Controls.SetChildIndex(this.CheckBoxSelectAll, 0);
			this.Controls.SetChildIndex(this.ButtonChooseWorkout, 0);
			this.Controls.SetChildIndex(this.ComboBoxWorkouts, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonGetPossibleAlbums;
		private System.Windows.Forms.Label LabelAlbumTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerAlbumTime;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label LabelTimeLeeway;
		private System.Windows.Forms.CheckBox CheckBoxSelectAll;
		private System.Windows.Forms.Button ButtonChooseWorkout;
		private System.Windows.Forms.ComboBox ComboBoxWorkouts;
	}
}
