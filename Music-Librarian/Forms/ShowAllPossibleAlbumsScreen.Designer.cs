
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
			this.ButtonShowSelectedAlbumTracklist = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ButtonShowSelectedAlbumTracklist
			// 
			this.ButtonShowSelectedAlbumTracklist.AutoSize = true;
			this.ButtonShowSelectedAlbumTracklist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonShowSelectedAlbumTracklist.BackColor = System.Drawing.Color.Transparent;
			this.ButtonShowSelectedAlbumTracklist.FlatAppearance.BorderSize = 0;
			this.ButtonShowSelectedAlbumTracklist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowSelectedAlbumTracklist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonShowSelectedAlbumTracklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonShowSelectedAlbumTracklist.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonShowSelectedAlbumTracklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonShowSelectedAlbumTracklist.Location = new System.Drawing.Point(282, 210);
			this.ButtonShowSelectedAlbumTracklist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonShowSelectedAlbumTracklist.Name = "ButtonShowSelectedAlbumTracklist";
			this.ButtonShowSelectedAlbumTracklist.Size = new System.Drawing.Size(269, 27);
			this.ButtonShowSelectedAlbumTracklist.TabIndex = 11;
			this.ButtonShowSelectedAlbumTracklist.Text = "Show Selected Album\'s Tracklist";
			this.ButtonShowSelectedAlbumTracklist.UseVisualStyleBackColor = false;
			this.ButtonShowSelectedAlbumTracklist.Click += new System.EventHandler(this.ButtonShowSelectedAlbumTracklist_Click);
			// 
			// ShowAllPossibleAlbumsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonShowSelectedAlbumTracklist);
			this.Name = "ShowAllPossibleAlbumsScreen";
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ButtonShowSelectedAlbumTracklist, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonShowSelectedAlbumTracklist;
	}
}
