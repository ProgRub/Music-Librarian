
namespace Forms
{
	partial class EditSongLyricsScreen
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
			this.TextBoxLyrics = new System.Windows.Forms.TextBox();
			this.LabelSongInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// TextBoxLyrics
			// 
			this.TextBoxLyrics.AcceptsReturn = true;
			this.TextBoxLyrics.AcceptsTab = true;
			this.TextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxLyrics.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxLyrics.Location = new System.Drawing.Point(62, 55);
			this.TextBoxLyrics.Multiline = true;
			this.TextBoxLyrics.Name = "TextBoxLyrics";
			this.TextBoxLyrics.Size = new System.Drawing.Size(581, 650);
			this.TextBoxLyrics.TabIndex = 6;
			// 
			// LabelSongInfo
			// 
			this.LabelSongInfo.Location = new System.Drawing.Point(62, 3);
			this.LabelSongInfo.Name = "LabelSongInfo";
			this.LabelSongInfo.Size = new System.Drawing.Size(581, 49);
			this.LabelSongInfo.TabIndex = 7;
			this.LabelSongInfo.Text = "Song Info";
			this.LabelSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EditSongLyricsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LabelSongInfo);
			this.Controls.Add(this.TextBoxLyrics);
			this.Name = "EditSongLyricsScreen";
			this.Size = new System.Drawing.Size(739, 708);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.TextBoxLyrics, 0);
			this.Controls.SetChildIndex(this.LabelSongInfo, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxLyrics;
		private System.Windows.Forms.Label LabelSongInfo;
	}
}
