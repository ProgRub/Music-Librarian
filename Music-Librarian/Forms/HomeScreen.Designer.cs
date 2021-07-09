
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
			this.LabelMusicStoredIn.AutoSize = true;
			this.LabelMusicStoredIn.Location = new System.Drawing.Point(3, 33);
			this.LabelMusicStoredIn.Name = "LabelMusicStoredIn";
			this.LabelMusicStoredIn.Size = new System.Drawing.Size(349, 17);
			this.LabelMusicStoredIn.TabIndex = 6;
			this.LabelMusicStoredIn.Text = "The Folder Where You Store All Your Music:";
			// 
			// TextBoxDirectory
			// 
			this.TextBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDirectory.Location = new System.Drawing.Point(369, 30);
			this.TextBoxDirectory.Name = "TextBoxDirectory";
			this.TextBoxDirectory.ReadOnly = true;
			this.TextBoxDirectory.Size = new System.Drawing.Size(454, 24);
			this.TextBoxDirectory.TabIndex = 7;
			// 
			// ButtonChooseFolder
			// 
			this.ButtonChooseFolder.AutoSize = true;
			this.ButtonChooseFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseFolder.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatAppearance.BorderSize = 0;
			this.ButtonChooseFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseFolder.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseFolder.Location = new System.Drawing.Point(830, 28);
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
			this.ButtonChooseAlbum.AutoSize = true;
			this.ButtonChooseAlbum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonChooseAlbum.BackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatAppearance.BorderSize = 0;
			this.ButtonChooseAlbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonChooseAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseAlbum.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonChooseAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonChooseAlbum.Location = new System.Drawing.Point(410, 75);
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
			this.ButtonSearchLibrary.AutoSize = true;
			this.ButtonSearchLibrary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSearchLibrary.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatAppearance.BorderSize = 0;
			this.ButtonSearchLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSearchLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSearchLibrary.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSearchLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSearchLibrary.Location = new System.Drawing.Point(410, 108);
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
			this.ButtonManageGenres.AutoSize = true;
			this.ButtonManageGenres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonManageGenres.BackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatAppearance.BorderSize = 0;
			this.ButtonManageGenres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonManageGenres.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonManageGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonManageGenres.Location = new System.Drawing.Point(410, 141);
			this.ButtonManageGenres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonManageGenres.Name = "ButtonManageGenres";
			this.ButtonManageGenres.Size = new System.Drawing.Size(137, 27);
			this.ButtonManageGenres.TabIndex = 11;
			this.ButtonManageGenres.Text = "Manage Genres";
			this.ButtonManageGenres.UseVisualStyleBackColor = false;
			this.ButtonManageGenres.Click += new System.EventHandler(this.ButtonManageGenres_Click);
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonManageGenres);
			this.Controls.Add(this.ButtonSearchLibrary);
			this.Controls.Add(this.ButtonChooseAlbum);
			this.Controls.Add(this.ButtonChooseFolder);
			this.Controls.Add(this.TextBoxDirectory);
			this.Controls.Add(this.LabelMusicStoredIn);
			this.Name = "HomeScreen";
			this.Size = new System.Drawing.Size(893, 447);
			this.Enter += new System.EventHandler(this.HomeScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.LabelMusicStoredIn, 0);
			this.Controls.SetChildIndex(this.TextBoxDirectory, 0);
			this.Controls.SetChildIndex(this.ButtonChooseFolder, 0);
			this.Controls.SetChildIndex(this.ButtonChooseAlbum, 0);
			this.Controls.SetChildIndex(this.ButtonSearchLibrary, 0);
			this.Controls.SetChildIndex(this.ButtonManageGenres, 0);
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
	}
}
