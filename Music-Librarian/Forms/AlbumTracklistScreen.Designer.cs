
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
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAlbumCover)).BeginInit();
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
			this.LabelArtistAndAlbumTitle.Location = new System.Drawing.Point(62, 3);
			this.LabelArtistAndAlbumTitle.Name = "LabelArtistAndAlbumTitle";
			this.LabelArtistAndAlbumTitle.Size = new System.Drawing.Size(581, 35);
			this.LabelArtistAndAlbumTitle.TabIndex = 14;
			this.LabelArtistAndAlbumTitle.Text = "This is the Tracklist for x - y";
			this.LabelArtistAndAlbumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextBoxTrackList
			// 
			this.TextBoxTrackList.AcceptsReturn = true;
			this.TextBoxTrackList.AcceptsTab = true;
			this.TextBoxTrackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxTrackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxTrackList.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxTrackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxTrackList.Location = new System.Drawing.Point(62, 41);
			this.TextBoxTrackList.Multiline = true;
			this.TextBoxTrackList.Name = "TextBoxTrackList";
			this.TextBoxTrackList.ReadOnly = true;
			this.TextBoxTrackList.Size = new System.Drawing.Size(581, 305);
			this.TextBoxTrackList.TabIndex = 15;
			// 
			// PictureBoxAlbumCover
			// 
			this.PictureBoxAlbumCover.Location = new System.Drawing.Point(649, 41);
			this.PictureBoxAlbumCover.Name = "PictureBoxAlbumCover";
			this.PictureBoxAlbumCover.Size = new System.Drawing.Size(300, 300);
			this.PictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxAlbumCover.TabIndex = 16;
			this.PictureBoxAlbumCover.TabStop = false;
			// 
			// ButtonShowAlbumOnService
			// 
			this.ButtonShowAlbumOnService.AutoSize = true;
			this.ButtonShowAlbumOnService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonShowAlbumOnService.BackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatAppearance.BorderSize = 0;
			this.ButtonShowAlbumOnService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowAlbumOnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonShowAlbumOnService.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonShowAlbumOnService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonShowAlbumOnService.Location = new System.Drawing.Point(707, 347);
			this.ButtonShowAlbumOnService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonShowAlbumOnService.Name = "ButtonShowAlbumOnService";
			this.ButtonShowAlbumOnService.Size = new System.Drawing.Size(197, 27);
			this.ButtonShowAlbumOnService.TabIndex = 17;
			this.ButtonShowAlbumOnService.Text = "Show Album on iTunes";
			this.ButtonShowAlbumOnService.UseVisualStyleBackColor = false;
			this.ButtonShowAlbumOnService.Click += new System.EventHandler(this.ButtonShowAlbumOnService_Click);
			// 
			// AlbumTrackListScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonShowAlbumOnService);
			this.Controls.Add(this.PictureBoxAlbumCover);
			this.Controls.Add(this.TextBoxTrackList);
			this.Controls.Add(this.LabelArtistAndAlbumTitle);
			this.Name = "AlbumTrackListScreen";
			this.Size = new System.Drawing.Size(952, 447);
			this.Enter += new System.EventHandler(this.AlbumTrackListScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.LabelArtistAndAlbumTitle, 0);
			this.Controls.SetChildIndex(this.TextBoxTrackList, 0);
			this.Controls.SetChildIndex(this.PictureBoxAlbumCover, 0);
			this.Controls.SetChildIndex(this.ButtonShowAlbumOnService, 0);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAlbumCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelArtistAndAlbumTitle;
		private System.Windows.Forms.TextBox TextBoxTrackList;
		private System.Windows.Forms.PictureBox PictureBoxAlbumCover;
		private System.Windows.Forms.Button ButtonShowAlbumOnService;
	}
}
