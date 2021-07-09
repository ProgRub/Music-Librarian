
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
			this.ButtonGetPossibleAlbums.AutoSize = true;
			this.ButtonGetPossibleAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonGetPossibleAlbums.BackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.BorderSize = 0;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonGetPossibleAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGetPossibleAlbums.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonGetPossibleAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonGetPossibleAlbums.Location = new System.Drawing.Point(254, 210);
			this.ButtonGetPossibleAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonGetPossibleAlbums.Name = "ButtonGetPossibleAlbums";
			this.ButtonGetPossibleAlbums.Size = new System.Drawing.Size(174, 27);
			this.ButtonGetPossibleAlbums.TabIndex = 10;
			this.ButtonGetPossibleAlbums.Text = "Get Possible Albums";
			this.ButtonGetPossibleAlbums.UseVisualStyleBackColor = false;
			this.ButtonGetPossibleAlbums.Click += new System.EventHandler(this.ButtonGetPossibleAlbums_Click);
			// 
			// SetAlbumPropertiesScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonGetPossibleAlbums);
			this.Name = "SetAlbumPropertiesScreen";
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ButtonGetPossibleAlbums, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonGetPossibleAlbums;
	}
}
