
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
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ListViewPossibleAlbums
			// 
			this.ListViewPossibleAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ListViewPossibleAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListViewPossibleAlbums.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderAlbumArtist,
            this.ColumnHeaderAlbum,
            this.ColumnHeaderDuration,
            this.ColumnHeaderAveragePlayCoun});
			this.ListViewPossibleAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListViewPossibleAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListViewPossibleAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ListViewPossibleAlbums.FullRowSelect = true;
			this.ListViewPossibleAlbums.LabelWrap = false;
			this.ListViewPossibleAlbums.Location = new System.Drawing.Point(3, 33);
			this.ListViewPossibleAlbums.MultiSelect = false;
			this.ListViewPossibleAlbums.Name = "ListViewPossibleAlbums";
			this.ListViewPossibleAlbums.Size = new System.Drawing.Size(1189, 387);
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
			this.LabelAlbumTimeRange.Location = new System.Drawing.Point(344, 13);
			this.LabelAlbumTimeRange.Name = "LabelAlbumTimeRange";
			this.LabelAlbumTimeRange.Size = new System.Drawing.Size(506, 17);
			this.LabelAlbumTimeRange.TabIndex = 13;
			this.LabelAlbumTimeRange.Text = "This is the list of albums whose duration range between x and y";
			this.LabelAlbumTimeRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelAlbumTimeRange, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ListViewPossibleAlbums, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(1192, 413);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1195, 423);
			this.tableLayoutPanelMain.TabIndex = 14;
			// 
			// ShowAllPossibleAlbumsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "ShowAllPossibleAlbumsScreen";
			this.Size = new System.Drawing.Size(1195, 423);
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
	}
}
