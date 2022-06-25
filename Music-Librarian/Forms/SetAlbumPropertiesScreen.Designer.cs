
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
			this.DateTimePickerLeeway = new System.Windows.Forms.DateTimePicker();
			this.LabelTimeLeeway = new System.Windows.Forms.Label();
			this.CheckBoxSelectAll = new System.Windows.Forms.CheckBox();
			this.ButtonChooseSelectWorkout = new System.Windows.Forms.Button();
			this.ComboBoxWorkouts = new System.Windows.Forms.ComboBox();
			this.ButtonAllAlbums = new System.Windows.Forms.Button();
			this.LabelLeewayType = new System.Windows.Forms.Label();
			this.RadioButtonBoth = new System.Windows.Forms.RadioButton();
			this.RadioButtonOver = new System.Windows.Forms.RadioButton();
			this.RadioButtonUnder = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain.SuspendLayout();
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
			this.ButtonGetPossibleAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonGetPossibleAlbums.AutoSize = true;
			this.ButtonGetPossibleAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonGetPossibleAlbums.BackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.BorderSize = 0;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGetPossibleAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonGetPossibleAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonGetPossibleAlbums.Location = new System.Drawing.Point(206, 114);
			this.ButtonGetPossibleAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonGetPossibleAlbums.Name = "ButtonGetPossibleAlbums";
			this.ButtonGetPossibleAlbums.Size = new System.Drawing.Size(194, 27);
			this.ButtonGetPossibleAlbums.TabIndex = 10;
			this.ButtonGetPossibleAlbums.Text = "Get Possible Albums";
			this.ButtonGetPossibleAlbums.UseVisualStyleBackColor = false;
			this.ButtonGetPossibleAlbums.Click += new System.EventHandler(this.ButtonGetPossibleAlbums_Click);
			// 
			// LabelAlbumTime
			// 
			this.LabelAlbumTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelAlbumTime.AutoSize = true;
			this.LabelAlbumTime.Location = new System.Drawing.Point(124, 32);
			this.LabelAlbumTime.Name = "LabelAlbumTime";
			this.LabelAlbumTime.Size = new System.Drawing.Size(75, 34);
			this.LabelAlbumTime.TabIndex = 18;
			this.LabelAlbumTime.Text = "Album Time:";
			// 
			// DateTimePickerAlbumTime
			// 
			this.DateTimePickerAlbumTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimePickerAlbumTime.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerAlbumTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.DateTimePickerAlbumTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerAlbumTime.CustomFormat = "HH:mm";
			this.DateTimePickerAlbumTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerAlbumTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerAlbumTime.Location = new System.Drawing.Point(205, 37);
			this.DateTimePickerAlbumTime.Name = "DateTimePickerAlbumTime";
			this.DateTimePickerAlbumTime.ShowUpDown = true;
			this.DateTimePickerAlbumTime.Size = new System.Drawing.Size(196, 24);
			this.DateTimePickerAlbumTime.TabIndex = 19;
			this.DateTimePickerAlbumTime.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
			// 
			// DateTimePickerLeeway
			// 
			this.DateTimePickerLeeway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimePickerLeeway.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerLeeway.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerLeeway.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.DateTimePickerLeeway.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerLeeway.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.DateTimePickerLeeway.CustomFormat = "HH:mm";
			this.DateTimePickerLeeway.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerLeeway.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerLeeway.Location = new System.Drawing.Point(205, 76);
			this.DateTimePickerLeeway.Name = "DateTimePickerLeeway";
			this.DateTimePickerLeeway.ShowUpDown = true;
			this.DateTimePickerLeeway.Size = new System.Drawing.Size(196, 24);
			this.DateTimePickerLeeway.TabIndex = 21;
			this.DateTimePickerLeeway.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
			// 
			// LabelTimeLeeway
			// 
			this.LabelTimeLeeway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelTimeLeeway.AutoSize = true;
			this.LabelTimeLeeway.Location = new System.Drawing.Point(124, 80);
			this.LabelTimeLeeway.Name = "LabelTimeLeeway";
			this.LabelTimeLeeway.Size = new System.Drawing.Size(75, 17);
			this.LabelTimeLeeway.TabIndex = 20;
			this.LabelTimeLeeway.Text = "Leeway:";
			// 
			// CheckBoxSelectAll
			// 
			this.CheckBoxSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckBoxSelectAll.AutoSize = true;
			this.CheckBoxSelectAll.Location = new System.Drawing.Point(3, 306);
			this.CheckBoxSelectAll.Name = "CheckBoxSelectAll";
			this.CheckBoxSelectAll.Size = new System.Drawing.Size(115, 21);
			this.CheckBoxSelectAll.TabIndex = 22;
			this.CheckBoxSelectAll.Text = "Select All";
			this.CheckBoxSelectAll.Click += new System.EventHandler(this.CheckBoxSelectAll_Click);
			// 
			// ButtonChooseSelectWorkout
			// 
			this.ButtonChooseSelectWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonChooseSelectWorkout.AutoSize = true;
			this.ButtonChooseSelectWorkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseSelectWorkout.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseSelectWorkout.FlatAppearance.BorderSize = 0;
			this.ButtonChooseSelectWorkout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseSelectWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseSelectWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseSelectWorkout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseSelectWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseSelectWorkout.Location = new System.Drawing.Point(408, 75);
			this.ButtonChooseSelectWorkout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonChooseSelectWorkout.Name = "ButtonChooseSelectWorkout";
			this.ButtonChooseSelectWorkout.Size = new System.Drawing.Size(399, 27);
			this.ButtonChooseSelectWorkout.TabIndex = 23;
			this.ButtonChooseSelectWorkout.Text = "Get Album Time For Selected Workout";
			this.ButtonChooseSelectWorkout.UseVisualStyleBackColor = false;
			this.ButtonChooseSelectWorkout.Click += new System.EventHandler(this.ButtonChooseWorkout_Click);
			// 
			// ComboBoxWorkouts
			// 
			this.ComboBoxWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBoxWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ComboBoxWorkouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxWorkouts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ComboBoxWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxWorkouts.FormattingEnabled = true;
			this.ComboBoxWorkouts.Location = new System.Drawing.Point(407, 37);
			this.ComboBoxWorkouts.Name = "ComboBoxWorkouts";
			this.ComboBoxWorkouts.Size = new System.Drawing.Size(401, 24);
			this.ComboBoxWorkouts.TabIndex = 24;
			// 
			// ButtonAllAlbums
			// 
			this.ButtonAllAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAllAlbums.AutoSize = true;
			this.ButtonAllAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAllAlbums.BackColor = System.Drawing.Color.Transparent;
			this.ButtonAllAlbums.FlatAppearance.BorderSize = 0;
			this.ButtonAllAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAllAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAllAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAllAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonAllAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonAllAlbums.Location = new System.Drawing.Point(4, 261);
			this.ButtonAllAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonAllAlbums.Name = "ButtonAllAlbums";
			this.ButtonAllAlbums.Size = new System.Drawing.Size(113, 27);
			this.ButtonAllAlbums.TabIndex = 25;
			this.ButtonAllAlbums.Text = "All Albums";
			this.ButtonAllAlbums.UseVisualStyleBackColor = false;
			this.ButtonAllAlbums.Click += new System.EventHandler(this.ButtonAllAlbums_Click);
			// 
			// LabelLeewayType
			// 
			this.LabelLeewayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelLeewayType.AutoSize = true;
			this.LabelLeewayType.Location = new System.Drawing.Point(3, 80);
			this.LabelLeewayType.Name = "LabelLeewayType";
			this.LabelLeewayType.Size = new System.Drawing.Size(115, 17);
			this.LabelLeewayType.TabIndex = 26;
			this.LabelLeewayType.Text = "Leeway Type";
			// 
			// RadioButtonBoth
			// 
			this.RadioButtonBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RadioButtonBoth.AutoSize = true;
			this.RadioButtonBoth.Checked = true;
			this.RadioButtonBoth.Location = new System.Drawing.Point(3, 117);
			this.RadioButtonBoth.Name = "RadioButtonBoth";
			this.RadioButtonBoth.Size = new System.Drawing.Size(115, 21);
			this.RadioButtonBoth.TabIndex = 27;
			this.RadioButtonBoth.TabStop = true;
			this.RadioButtonBoth.Text = "Both";
			this.RadioButtonBoth.UseVisualStyleBackColor = true;
			// 
			// RadioButtonOver
			// 
			this.RadioButtonOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RadioButtonOver.AutoSize = true;
			this.RadioButtonOver.Location = new System.Drawing.Point(3, 156);
			this.RadioButtonOver.Name = "RadioButtonOver";
			this.RadioButtonOver.Size = new System.Drawing.Size(115, 21);
			this.RadioButtonOver.TabIndex = 28;
			this.RadioButtonOver.Text = "Over";
			this.RadioButtonOver.UseVisualStyleBackColor = true;
			// 
			// RadioButtonUnder
			// 
			this.RadioButtonUnder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RadioButtonUnder.AutoSize = true;
			this.RadioButtonUnder.Location = new System.Drawing.Point(3, 195);
			this.RadioButtonUnder.Name = "RadioButtonUnder";
			this.RadioButtonUnder.Size = new System.Drawing.Size(115, 21);
			this.RadioButtonUnder.TabIndex = 29;
			this.RadioButtonUnder.Text = "Under";
			this.RadioButtonUnder.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 4;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelAlbumTime, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonGetPossibleAlbums, 2, 3);
			this.tableLayoutPanelMain.Controls.Add(this.RadioButtonUnder, 0, 5);
			this.tableLayoutPanelMain.Controls.Add(this.LabelTimeLeeway, 1, 2);
			this.tableLayoutPanelMain.Controls.Add(this.RadioButtonOver, 0, 4);
			this.tableLayoutPanelMain.Controls.Add(this.DateTimePickerAlbumTime, 2, 1);
			this.tableLayoutPanelMain.Controls.Add(this.RadioButtonBoth, 0, 3);
			this.tableLayoutPanelMain.Controls.Add(this.DateTimePickerLeeway, 2, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelLeewayType, 0, 2);
			this.tableLayoutPanelMain.Controls.Add(this.ComboBoxWorkouts, 3, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonChooseSelectWorkout, 3, 2);
			this.tableLayoutPanelMain.Controls.Add(this.CheckBoxSelectAll, 0, 8);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonAllAlbums, 0, 7);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(811, 339);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 9;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28878F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28878F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(811, 339);
			this.tableLayoutPanelMain.TabIndex = 30;
			// 
			// SetAlbumPropertiesScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "SetAlbumPropertiesScreen";
			this.Size = new System.Drawing.Size(809, 306);
			this.Enter += new System.EventHandler(this.SetAlbumPropertiesScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonGetPossibleAlbums;
		private System.Windows.Forms.Label LabelAlbumTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerAlbumTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerLeeway;
		private System.Windows.Forms.Label LabelTimeLeeway;
		private System.Windows.Forms.CheckBox CheckBoxSelectAll;
		private System.Windows.Forms.Button ButtonChooseSelectWorkout;
		private System.Windows.Forms.ComboBox ComboBoxWorkouts;
		private System.Windows.Forms.Button ButtonAllAlbums;
		private System.Windows.Forms.Label LabelLeewayType;
		private System.Windows.Forms.RadioButton RadioButtonBoth;
		private System.Windows.Forms.RadioButton RadioButtonOver;
		private System.Windows.Forms.RadioButton RadioButtonUnder;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
