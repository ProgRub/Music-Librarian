
namespace Forms
{
	partial class AlbumTracklistScreen
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
			this.TextBoxTraclist = new System.Windows.Forms.TextBox();
			this.PictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
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
			this.LabelArtistAndAlbumTitle.AutoSize = true;
			this.LabelArtistAndAlbumTitle.Location = new System.Drawing.Point(217, 13);
			this.LabelArtistAndAlbumTitle.Name = "LabelArtistAndAlbumTitle";
			this.LabelArtistAndAlbumTitle.Size = new System.Drawing.Size(225, 17);
			this.LabelArtistAndAlbumTitle.TabIndex = 14;
			this.LabelArtistAndAlbumTitle.Text = "This is the Tracklist for x - y";
			this.LabelArtistAndAlbumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextBoxTraclist
			// 
			this.TextBoxTraclist.AcceptsReturn = true;
			this.TextBoxTraclist.AcceptsTab = true;
			this.TextBoxTraclist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxTraclist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxTraclist.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxTraclist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxTraclist.Location = new System.Drawing.Point(34, 47);
			this.TextBoxTraclist.Multiline = true;
			this.TextBoxTraclist.Name = "TextBoxTraclist";
			this.TextBoxTraclist.Size = new System.Drawing.Size(581, 305);
			this.TextBoxTraclist.TabIndex = 15;
			// 
			// PictureBoxAlbumCover
			// 
			this.PictureBoxAlbumCover.Location = new System.Drawing.Point(621, 47);
			this.PictureBoxAlbumCover.Name = "PictureBoxAlbumCover";
			this.PictureBoxAlbumCover.Size = new System.Drawing.Size(300, 300);
			this.PictureBoxAlbumCover.TabIndex = 16;
			this.PictureBoxAlbumCover.TabStop = false;
			// 
			// AlbumTracklistScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PictureBoxAlbumCover);
			this.Controls.Add(this.TextBoxTraclist);
			this.Controls.Add(this.LabelArtistAndAlbumTitle);
			this.Name = "AlbumTracklistScreen";
			this.Size = new System.Drawing.Size(924, 447);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.LabelArtistAndAlbumTitle, 0);
			this.Controls.SetChildIndex(this.TextBoxTraclist, 0);
			this.Controls.SetChildIndex(this.PictureBoxAlbumCover, 0);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxAlbumCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelArtistAndAlbumTitle;
		private System.Windows.Forms.TextBox TextBoxTraclist;
		private System.Windows.Forms.PictureBox PictureBoxAlbumCover;
	}
}
