
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
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain.SuspendLayout();
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
			this.TextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanelMain.SetColumnSpan(this.TextBoxLyrics, 3);
			this.TextBoxLyrics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxLyrics.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxLyrics.Location = new System.Drawing.Point(53, 33);
			this.TextBoxLyrics.Multiline = true;
			this.TextBoxLyrics.Name = "TextBoxLyrics";
			this.TextBoxLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxLyrics.Size = new System.Drawing.Size(638, 506);
			this.TextBoxLyrics.TabIndex = 6;
			// 
			// LabelSongInfo
			// 
			this.LabelSongInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tableLayoutPanelMain.SetColumnSpan(this.LabelSongInfo, 3);
			this.LabelSongInfo.Location = new System.Drawing.Point(53, 0);
			this.LabelSongInfo.Name = "LabelSongInfo";
			this.LabelSongInfo.Size = new System.Drawing.Size(638, 30);
			this.LabelSongInfo.TabIndex = 7;
			this.LabelSongInfo.Text = "Song Info";
			this.LabelSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonSaveChanges
			// 
			this.ButtonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonSaveChanges.AutoSize = true;
			this.ButtonSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSaveChanges.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.BorderSize = 0;
			this.ButtonSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSaveChanges.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSaveChanges.Location = new System.Drawing.Point(698, 512);
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
			this.ButtonRedo.Location = new System.Drawing.Point(396, 545);
			this.ButtonRedo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonRedo.Name = "ButtonRedo";
			this.ButtonRedo.Size = new System.Drawing.Size(22, 19);
			this.ButtonRedo.TabIndex = 60;
			this.ButtonRedo.UseVisualStyleBackColor = false;
			this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
			// 
			// ButtonUndo
			// 
			this.ButtonUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.ButtonUndo.Location = new System.Drawing.Point(326, 545);
			this.ButtonUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonUndo.Name = "ButtonUndo";
			this.ButtonUndo.Size = new System.Drawing.Size(22, 19);
			this.ButtonUndo.TabIndex = 59;
			this.ButtonUndo.UseVisualStyleBackColor = false;
			this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 5;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanelMain.Controls.Add(this.LabelSongInfo, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonRedo, 3, 2);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonSaveChanges, 4, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonUndo, 1, 2);
			this.tableLayoutPanelMain.Controls.Add(this.TextBoxLyrics, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(830, 563);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(834, 567);
			this.tableLayoutPanelMain.TabIndex = 61;
			// 
			// EditSongLyricsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "EditSongLyricsScreen";
			this.Size = new System.Drawing.Size(834, 567);
			this.Enter += new System.EventHandler(this.EditSongLyricsScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxLyrics;
		private System.Windows.Forms.Label LabelSongInfo;
		private System.Windows.Forms.Button ButtonSaveChanges;
		private System.Windows.Forms.Button ButtonRedo;
		private System.Windows.Forms.Button ButtonUndo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
