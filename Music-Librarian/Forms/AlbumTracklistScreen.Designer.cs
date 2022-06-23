
namespace Forms
{
	partial class AlbumTrackListScreen
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
			this.LabelArtistAndAlbumTitle = new System.Windows.Forms.Label();
			this.TextBoxTrackList = new System.Windows.Forms.TextBox();
			this.PictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
			this.ButtonShowAlbumOnService = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAlbumCover)).BeginInit();
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// LabelArtistAndAlbumTitle
			// 
			this.LabelArtistAndAlbumTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelArtistAndAlbumTitle.Location = new System.Drawing.Point(55, 0);
			this.LabelArtistAndAlbumTitle.Name = "LabelArtistAndAlbumTitle";
			this.LabelArtistAndAlbumTitle.Size = new System.Drawing.Size(581, 30);
			this.LabelArtistAndAlbumTitle.TabIndex = 14;
			this.LabelArtistAndAlbumTitle.Text = "This is the Tracklist for º - ª";
			this.LabelArtistAndAlbumTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// TextBoxTrackList
			// 
			this.TextBoxTrackList.AcceptsReturn = true;
			this.TextBoxTrackList.AcceptsTab = true;
			this.TextBoxTrackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxTrackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxTrackList.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxTrackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxTrackList.Location = new System.Drawing.Point(53, 33);
			this.TextBoxTrackList.Multiline = true;
			this.TextBoxTrackList.Name = "TextBoxTrackList";
			this.TextBoxTrackList.ReadOnly = true;
			this.tableLayoutPanelMain.SetRowSpan(this.TextBoxTrackList, 2);
			this.TextBoxTrackList.Size = new System.Drawing.Size(586, 307);
			this.TextBoxTrackList.TabIndex = 15;
			// 
			// PictureBoxAlbumCover
			// 
			this.PictureBoxAlbumCover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBoxAlbumCover.Location = new System.Drawing.Point(645, 33);
			this.PictureBoxAlbumCover.Name = "PictureBoxAlbumCover";
			this.PictureBoxAlbumCover.Size = new System.Drawing.Size(314, 260);
			this.PictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxAlbumCover.TabIndex = 16;
			this.PictureBoxAlbumCover.TabStop = false;
			// 
			// ButtonShowAlbumOnService
			// 
			this.ButtonShowAlbumOnService.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonShowAlbumOnService.AutoSize = true;
			this.ButtonShowAlbumOnService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonShowAlbumOnService.BackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatAppearance.BorderSize = 0;
			this.ButtonShowAlbumOnService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonShowAlbumOnService.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonShowAlbumOnService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonShowAlbumOnService.Location = new System.Drawing.Point(703, 299);
			this.ButtonShowAlbumOnService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonShowAlbumOnService.Name = "ButtonShowAlbumOnService";
			this.ButtonShowAlbumOnService.Size = new System.Drawing.Size(197, 27);
			this.ButtonShowAlbumOnService.TabIndex = 17;
			this.ButtonShowAlbumOnService.Text = "Show Album on iTunes";
			this.ButtonShowAlbumOnService.UseVisualStyleBackColor = false;
			this.ButtonShowAlbumOnService.Click += new System.EventHandler(this.ButtonShowAlbumOnService_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelArtistAndAlbumTitle, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonShowAlbumOnService, 2, 2);
			this.tableLayoutPanelMain.Controls.Add(this.TextBoxTrackList, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.PictureBoxAlbumCover, 2, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(960, 336);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(962, 343);
			this.tableLayoutPanelMain.TabIndex = 18;
			// 
			// AlbumTrackListScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "AlbumTrackListScreen";
			this.Size = new System.Drawing.Size(962, 343);
			this.Enter += new System.EventHandler(this.AlbumTrackListScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAlbumCover)).EndInit();
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelArtistAndAlbumTitle;
		private System.Windows.Forms.TextBox TextBoxTrackList;
		private System.Windows.Forms.PictureBox PictureBoxAlbumCover;
		private System.Windows.Forms.Button ButtonShowAlbumOnService;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
