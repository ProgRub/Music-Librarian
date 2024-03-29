﻿
namespace Forms
{
	partial class ShowAllPossibleAlbumsScreen
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
			this.ListViewPossibleAlbums = new System.Windows.Forms.ListView();
			this.ColumnHeaderAlbumArtist = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderAlbum = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderDuration = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeaderAveragePlayCoun = new System.Windows.Forms.ColumnHeader();
			this.LabelAlbumTimeRange = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.ColumnHeaderAverageRating = new System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.Location = new System.Drawing.Point(0, 4);
			this.ButtonBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			// 
			// ListViewPossibleAlbums
			// 
			this.ListViewPossibleAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ListViewPossibleAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListViewPossibleAlbums.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderAlbumArtist,
            this.ColumnHeaderAlbum,
            this.ColumnHeaderDuration,
            this.ColumnHeaderAveragePlayCoun,
            this.ColumnHeaderAverageRating});
			this.ListViewPossibleAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListViewPossibleAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListViewPossibleAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ListViewPossibleAlbums.FullRowSelect = true;
			this.ListViewPossibleAlbums.LabelWrap = false;
			this.ListViewPossibleAlbums.Location = new System.Drawing.Point(4, 42);
			this.ListViewPossibleAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ListViewPossibleAlbums.MultiSelect = false;
			this.ListViewPossibleAlbums.Name = "ListViewPossibleAlbums";
			this.ListViewPossibleAlbums.Size = new System.Drawing.Size(1585, 483);
			this.ListViewPossibleAlbums.TabIndex = 12;
			this.ListViewPossibleAlbums.UseCompatibleStateImageBehavior = false;
			this.ListViewPossibleAlbums.View = System.Windows.Forms.View.Details;
			this.ListViewPossibleAlbums.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewPossibleAlbums_ColumnClick);
			this.ListViewPossibleAlbums.DoubleClick += new System.EventHandler(this.ListViewPossibleAlbums_DoubleClick);
			// 
			// ColumnHeaderAlbumArtist
			// 
			this.ColumnHeaderAlbumArtist.Text = "Album Artist";
			this.ColumnHeaderAlbumArtist.Width = 300;
			// 
			// ColumnHeaderAlbum
			// 
			this.ColumnHeaderAlbum.Text = "Album";
			this.ColumnHeaderAlbum.Width = 580;
			// 
			// ColumnHeaderDuration
			// 
			this.ColumnHeaderDuration.Text = "Album Duration";
			this.ColumnHeaderDuration.Width = 125;
			// 
			// ColumnHeaderAveragePlayCoun
			// 
			this.ColumnHeaderAveragePlayCoun.Text = "Average Play Count";
			this.ColumnHeaderAveragePlayCoun.Width = 150;
			// 
			// LabelAlbumTimeRange
			// 
			this.LabelAlbumTimeRange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelAlbumTimeRange.AutoSize = true;
			this.LabelAlbumTimeRange.Location = new System.Drawing.Point(485, 18);
			this.LabelAlbumTimeRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelAlbumTimeRange.Name = "LabelAlbumTimeRange";
			this.LabelAlbumTimeRange.Size = new System.Drawing.Size(622, 20);
			this.LabelAlbumTimeRange.TabIndex = 13;
			this.LabelAlbumTimeRange.Text = "This is the list of albums whose duration range between x and y";
			this.LabelAlbumTimeRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelAlbumTimeRange, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ListViewPossibleAlbums, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(1589, 516);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1593, 529);
			this.tableLayoutPanelMain.TabIndex = 14;
			// 
			// ColumnHeaderAverageRating
			// 
			this.ColumnHeaderAverageRating.Text = "Average Rating";
			this.ColumnHeaderAverageRating.Width = 150;
			// 
			// ShowAllPossibleAlbumsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "ShowAllPossibleAlbumsScreen";
			this.Size = new System.Drawing.Size(1593, 529);
			this.Enter += new System.EventHandler(this.ShowAllPossibleAlbumsScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListView ListViewPossibleAlbums;
		private System.Windows.Forms.ColumnHeader ColumnHeaderAlbumArtist;
		private System.Windows.Forms.ColumnHeader ColumnHeaderAlbum;
		private System.Windows.Forms.ColumnHeader ColumnHeaderDuration;
		private System.Windows.Forms.ColumnHeader ColumnHeaderAveragePlayCoun;
		private System.Windows.Forms.Label LabelAlbumTimeRange;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.ColumnHeader ColumnHeaderAverageRating;
	}
}
