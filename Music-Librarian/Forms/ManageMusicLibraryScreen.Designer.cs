
namespace Forms
{
	partial class ManageMusicLibraryScreen
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
			this.ButtonEditSelectedSongLyrics = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ButtonEditSelectedSongLyrics
			// 
			this.ButtonEditSelectedSongLyrics.AutoSize = true;
			this.ButtonEditSelectedSongLyrics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonEditSelectedSongLyrics.BackColor = System.Drawing.Color.Transparent;
			this.ButtonEditSelectedSongLyrics.FlatAppearance.BorderSize = 0;
			this.ButtonEditSelectedSongLyrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonEditSelectedSongLyrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonEditSelectedSongLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonEditSelectedSongLyrics.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonEditSelectedSongLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonEditSelectedSongLyrics.Location = new System.Drawing.Point(282, 210);
			this.ButtonEditSelectedSongLyrics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonEditSelectedSongLyrics.Name = "ButtonEditSelectedSongLyrics";
			this.ButtonEditSelectedSongLyrics.Size = new System.Drawing.Size(226, 27);
			this.ButtonEditSelectedSongLyrics.TabIndex = 11;
			this.ButtonEditSelectedSongLyrics.Text = "Edit Selected Song\'s Lyrics";
			this.ButtonEditSelectedSongLyrics.UseVisualStyleBackColor = false;
			this.ButtonEditSelectedSongLyrics.Click += new System.EventHandler(this.ButtonEditSelectedSongLyrics_Click);
			// 
			// ManageMusicLibraryScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonEditSelectedSongLyrics);
			this.Name = "ManageMusicLibraryScreen";
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ButtonEditSelectedSongLyrics, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonEditSelectedSongLyrics;
	}
}
