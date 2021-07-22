
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
			this.ButtonSaveChanges = new System.Windows.Forms.Button();
			this.ButtonRedo = new System.Windows.Forms.Button();
			this.ButtonUndo = new System.Windows.Forms.Button();
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
			this.TextBoxLyrics.Size = new System.Drawing.Size(740, 650);
			this.TextBoxLyrics.TabIndex = 6;
			// 
			// LabelSongInfo
			// 
			this.LabelSongInfo.Location = new System.Drawing.Point(62, 3);
			this.LabelSongInfo.Name = "LabelSongInfo";
			this.LabelSongInfo.Size = new System.Drawing.Size(740, 49);
			this.LabelSongInfo.TabIndex = 7;
			this.LabelSongInfo.Text = "Song Info";
			this.LabelSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonSaveChanges
			// 
			this.ButtonSaveChanges.AutoSize = true;
			this.ButtonSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSaveChanges.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.BorderSize = 0;
			this.ButtonSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSaveChanges.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSaveChanges.Location = new System.Drawing.Point(809, 678);
			this.ButtonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonSaveChanges.Name = "ButtonSaveChanges";
			this.ButtonSaveChanges.Size = new System.Drawing.Size(127, 27);
			this.ButtonSaveChanges.TabIndex = 58;
			this.ButtonSaveChanges.Text = "Save Changes";
			this.ButtonSaveChanges.UseVisualStyleBackColor = false;
			this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
			// 
			// ButtonRedo
			// 
			this.ButtonRedo.AutoSize = true;
			this.ButtonRedo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonRedo.BackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.Enabled = false;
			this.ButtonRedo.FlatAppearance.BorderSize = 0;
			this.ButtonRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRedo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonRedo.Image = global::Forms.Properties.Resources.Redo;
			this.ButtonRedo.Location = new System.Drawing.Point(468, 711);
			this.ButtonRedo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonRedo.Name = "ButtonRedo";
			this.ButtonRedo.Size = new System.Drawing.Size(22, 22);
			this.ButtonRedo.TabIndex = 60;
			this.ButtonRedo.UseVisualStyleBackColor = false;
			this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
			// 
			// ButtonUndo
			// 
			this.ButtonUndo.AutoSize = true;
			this.ButtonUndo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonUndo.BackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.Enabled = false;
			this.ButtonUndo.FlatAppearance.BorderSize = 0;
			this.ButtonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonUndo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonUndo.Image = global::Forms.Properties.Resources.Undo;
			this.ButtonUndo.Location = new System.Drawing.Point(375, 711);
			this.ButtonUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonUndo.Name = "ButtonUndo";
			this.ButtonUndo.Size = new System.Drawing.Size(22, 22);
			this.ButtonUndo.TabIndex = 59;
			this.ButtonUndo.UseVisualStyleBackColor = false;
			this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
			// 
			// EditSongLyricsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonRedo);
			this.Controls.Add(this.ButtonUndo);
			this.Controls.Add(this.ButtonSaveChanges);
			this.Controls.Add(this.LabelSongInfo);
			this.Controls.Add(this.TextBoxLyrics);
			this.Name = "EditSongLyricsScreen";
			this.Size = new System.Drawing.Size(940, 761);
			this.Enter += new System.EventHandler(this.EditSongLyricsScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.TextBoxLyrics, 0);
			this.Controls.SetChildIndex(this.LabelSongInfo, 0);
			this.Controls.SetChildIndex(this.ButtonSaveChanges, 0);
			this.Controls.SetChildIndex(this.ButtonUndo, 0);
			this.Controls.SetChildIndex(this.ButtonRedo, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxLyrics;
		private System.Windows.Forms.Label LabelSongInfo;
		private System.Windows.Forms.Button ButtonSaveChanges;
		private System.Windows.Forms.Button ButtonRedo;
		private System.Windows.Forms.Button ButtonUndo;
	}
}
