
namespace Forms
{
	partial class HomeScreen
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
			this.LabelMusicStoredIn = new System.Windows.Forms.Label();
			this.TextBoxDirectory = new System.Windows.Forms.TextBox();
			this.ButtonChooseFolder = new System.Windows.Forms.Button();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.ButtonChooseAlbum = new System.Windows.Forms.Button();
			this.ButtonSearchLibrary = new System.Windows.Forms.Button();
			this.ButtonManageGenres = new System.Windows.Forms.Button();
			this.ButtonUpdatePlayCounts = new System.Windows.Forms.Button();
			this.ButtonSetPlayCountsFromDB = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.Enabled = false;
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.Visible = false;
			// 
			// LabelMusicStoredIn
			// 
			this.LabelMusicStoredIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelMusicStoredIn.AutoSize = true;
			this.LabelMusicStoredIn.Location = new System.Drawing.Point(7, 5);
			this.LabelMusicStoredIn.Name = "LabelMusicStoredIn";
			this.LabelMusicStoredIn.Size = new System.Drawing.Size(187, 34);
			this.LabelMusicStoredIn.TabIndex = 6;
			this.LabelMusicStoredIn.Text = "The Folder Where You Store All Your Music:";
			// 
			// TextBoxDirectory
			// 
			this.TextBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDirectory.Location = new System.Drawing.Point(200, 10);
			this.TextBoxDirectory.Name = "TextBoxDirectory";
			this.TextBoxDirectory.ReadOnly = true;
			this.TextBoxDirectory.Size = new System.Drawing.Size(686, 24);
			this.TextBoxDirectory.TabIndex = 7;
			// 
			// ButtonChooseFolder
			// 
			this.ButtonChooseFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonChooseFolder.AutoSize = true;
			this.ButtonChooseFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseFolder.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatAppearance.BorderSize = 0;
			this.ButtonChooseFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseFolder.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseFolder.Location = new System.Drawing.Point(893, 8);
			this.ButtonChooseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonChooseFolder.Name = "ButtonChooseFolder";
			this.ButtonChooseFolder.Size = new System.Drawing.Size(59, 27);
			this.ButtonChooseFolder.TabIndex = 8;
			this.ButtonChooseFolder.Text = "Open";
			this.ButtonChooseFolder.UseVisualStyleBackColor = false;
			this.ButtonChooseFolder.Click += new System.EventHandler(this.ButtonChooseFolder_Click);
			// 
			// FolderBrowserDialog
			// 
			this.FolderBrowserDialog.UseDescriptionForTitle = true;
			// 
			// ButtonChooseAlbum
			// 
			this.ButtonChooseAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonChooseAlbum.AutoSize = true;
			this.ButtonChooseAlbum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseAlbum.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatAppearance.BorderSize = 0;
			this.ButtonChooseAlbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseAlbum.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseAlbum.Location = new System.Drawing.Point(427, 47);
			this.ButtonChooseAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonChooseAlbum.Name = "ButtonChooseAlbum";
			this.ButtonChooseAlbum.Size = new System.Drawing.Size(231, 27);
			this.ButtonChooseAlbum.TabIndex = 9;
			this.ButtonChooseAlbum.Text = "Choose Album To Listen To";
			this.ButtonChooseAlbum.UseVisualStyleBackColor = false;
			this.ButtonChooseAlbum.Click += new System.EventHandler(this.ButtonChooseAlbum_Click);
			// 
			// ButtonSearchLibrary
			// 
			this.ButtonSearchLibrary.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonSearchLibrary.AutoSize = true;
			this.ButtonSearchLibrary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSearchLibrary.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatAppearance.BorderSize = 0;
			this.ButtonSearchLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSearchLibrary.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSearchLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSearchLibrary.Location = new System.Drawing.Point(419, 91);
			this.ButtonSearchLibrary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonSearchLibrary.Name = "ButtonSearchLibrary";
			this.ButtonSearchLibrary.Size = new System.Drawing.Size(248, 27);
			this.ButtonSearchLibrary.TabIndex = 10;
			this.ButtonSearchLibrary.Text = "Search and Edit Music Library";
			this.ButtonSearchLibrary.UseVisualStyleBackColor = false;
			this.ButtonSearchLibrary.Click += new System.EventHandler(this.ButtonSearchLibrary_Click);
			// 
			// ButtonManageGenres
			// 
			this.ButtonManageGenres.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonManageGenres.AutoSize = true;
			this.ButtonManageGenres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonManageGenres.BackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatAppearance.BorderSize = 0;
			this.ButtonManageGenres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonManageGenres.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonManageGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonManageGenres.Location = new System.Drawing.Point(474, 135);
			this.ButtonManageGenres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonManageGenres.Name = "ButtonManageGenres";
			this.ButtonManageGenres.Size = new System.Drawing.Size(137, 27);
			this.ButtonManageGenres.TabIndex = 11;
			this.ButtonManageGenres.Text = "Manage Genres";
			this.ButtonManageGenres.UseVisualStyleBackColor = false;
			this.ButtonManageGenres.Click += new System.EventHandler(this.ButtonManageGenres_Click);
			// 
			// ButtonUpdatePlayCounts
			// 
			this.ButtonUpdatePlayCounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonUpdatePlayCounts.AutoSize = true;
			this.ButtonUpdatePlayCounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonUpdatePlayCounts.BackColor = System.Drawing.Color.Transparent;
			this.ButtonUpdatePlayCounts.FlatAppearance.BorderSize = 0;
			this.ButtonUpdatePlayCounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonUpdatePlayCounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonUpdatePlayCounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonUpdatePlayCounts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonUpdatePlayCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonUpdatePlayCounts.Location = new System.Drawing.Point(458, 179);
			this.ButtonUpdatePlayCounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonUpdatePlayCounts.Name = "ButtonUpdatePlayCounts";
			this.ButtonUpdatePlayCounts.Size = new System.Drawing.Size(170, 27);
			this.ButtonUpdatePlayCounts.TabIndex = 12;
			this.ButtonUpdatePlayCounts.Text = "Update Play Counts";
			this.ButtonUpdatePlayCounts.UseVisualStyleBackColor = false;
			this.ButtonUpdatePlayCounts.Click += new System.EventHandler(this.ButtonUpdatePlayCounts_Click);
			// 
			// ButtonSetPlayCountsFromDB
			// 
			this.ButtonSetPlayCountsFromDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonSetPlayCountsFromDB.AutoSize = true;
			this.ButtonSetPlayCountsFromDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSetPlayCountsFromDB.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSetPlayCountsFromDB.FlatAppearance.BorderSize = 0;
			this.ButtonSetPlayCountsFromDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSetPlayCountsFromDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSetPlayCountsFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSetPlayCountsFromDB.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSetPlayCountsFromDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSetPlayCountsFromDB.Location = new System.Drawing.Point(437, 223);
			this.ButtonSetPlayCountsFromDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonSetPlayCountsFromDB.Name = "ButtonSetPlayCountsFromDB";
			this.ButtonSetPlayCountsFromDB.Size = new System.Drawing.Size(212, 27);
			this.ButtonSetPlayCountsFromDB.TabIndex = 13;
			this.ButtonSetPlayCountsFromDB.Text = "Set Play Counts From DB";
			this.ButtonSetPlayCountsFromDB.UseVisualStyleBackColor = false;
			this.ButtonSetPlayCountsFromDB.Click += new System.EventHandler(this.ButtonSetPlayCountsFromDB_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelMusicStoredIn, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonSetPlayCountsFromDB, 1, 5);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonChooseFolder, 2, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonUpdatePlayCounts, 1, 4);
			this.tableLayoutPanelMain.Controls.Add(this.TextBoxDirectory, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonManageGenres, 1, 3);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonChooseAlbum, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonSearchLibrary, 1, 2);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(978, 256);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 6;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6632F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(989, 266);
			this.tableLayoutPanelMain.TabIndex = 14;
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "HomeScreen";
			this.Size = new System.Drawing.Size(989, 266);
			this.Enter += new System.EventHandler(this.HomeScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelMusicStoredIn;
		private System.Windows.Forms.TextBox TextBoxDirectory;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
		private System.Windows.Forms.Button ButtonChooseAlbum;
		private System.Windows.Forms.Button ButtonSearchLibrary;
		private System.Windows.Forms.Button ButtonManageGenres;
		private System.Windows.Forms.Button ButtonChooseFolder;
		private System.Windows.Forms.Button ButtonUpdatePlayCounts;
		private System.Windows.Forms.Button ButtonSetPlayCountsFromDB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
