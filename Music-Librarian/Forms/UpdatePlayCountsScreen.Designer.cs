
namespace Forms
{
	partial class UpdatePlayCountsScreen
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
			this.LabelArtist = new System.Windows.Forms.Label();
			this.LabelAlbum = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.LabelPlayCountChange = new System.Windows.Forms.Label();
			this.SyncRichTextBoxArtist = new Forms.SyncRichTextBox();
			this.SyncRichTextBoxAlbum = new Forms.SyncRichTextBox();
			this.SyncRichTextBoxTitle = new Forms.SyncRichTextBox();
			this.SyncRichTextBoxPlayCountChange = new Forms.SyncRichTextBox();
			this.LabelAllDone = new System.Windows.Forms.Label();
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
			// LabelArtist
			// 
			this.LabelArtist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelArtist.AutoSize = true;
			this.LabelArtist.Location = new System.Drawing.Point(103, 48);
			this.LabelArtist.Name = "LabelArtist";
			this.LabelArtist.Size = new System.Drawing.Size(50, 17);
			this.LabelArtist.TabIndex = 7;
			this.LabelArtist.Text = "Artist";
			// 
			// LabelAlbum
			// 
			this.LabelAlbum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelAlbum.AutoSize = true;
			this.LabelAlbum.Location = new System.Drawing.Point(454, 48);
			this.LabelAlbum.Name = "LabelAlbum";
			this.LabelAlbum.Size = new System.Drawing.Size(57, 17);
			this.LabelAlbum.TabIndex = 9;
			this.LabelAlbum.Text = "Album";
			// 
			// LabelTitle
			// 
			this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelTitle.AutoSize = true;
			this.LabelTitle.Location = new System.Drawing.Point(913, 48);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(41, 17);
			this.LabelTitle.TabIndex = 11;
			this.LabelTitle.Text = "Title";
			// 
			// LabelPlayCountChange
			// 
			this.LabelPlayCountChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelPlayCountChange.AutoSize = true;
			this.LabelPlayCountChange.Location = new System.Drawing.Point(1175, 31);
			this.LabelPlayCountChange.Name = "LabelPlayCountChange";
			this.LabelPlayCountChange.Size = new System.Drawing.Size(97, 34);
			this.LabelPlayCountChange.TabIndex = 13;
			this.LabelPlayCountChange.Text = "Play Count Changes";
			// 
			// SyncRichTextBoxArtist
			// 
			this.SyncRichTextBoxArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.SyncRichTextBoxArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SyncRichTextBoxArtist.Buddies = null;
			this.SyncRichTextBoxArtist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SyncRichTextBoxArtist.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SyncRichTextBoxArtist.ForeColor = System.Drawing.Color.Yellow;
			this.SyncRichTextBoxArtist.Location = new System.Drawing.Point(3, 68);
			this.SyncRichTextBoxArtist.Name = "SyncRichTextBoxArtist";
			this.SyncRichTextBoxArtist.ReadOnly = true;
			this.SyncRichTextBoxArtist.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.SyncRichTextBoxArtist.Size = new System.Drawing.Size(251, 665);
			this.SyncRichTextBoxArtist.TabIndex = 14;
			this.SyncRichTextBoxArtist.Text = "";
			this.SyncRichTextBoxArtist.WordWrap = false;
			// 
			// SyncRichTextBoxAlbum
			// 
			this.SyncRichTextBoxAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.SyncRichTextBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SyncRichTextBoxAlbum.Buddies = null;
			this.SyncRichTextBoxAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SyncRichTextBoxAlbum.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SyncRichTextBoxAlbum.ForeColor = System.Drawing.Color.Yellow;
			this.SyncRichTextBoxAlbum.Location = new System.Drawing.Point(260, 68);
			this.SyncRichTextBoxAlbum.Name = "SyncRichTextBoxAlbum";
			this.SyncRichTextBoxAlbum.ReadOnly = true;
			this.SyncRichTextBoxAlbum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.SyncRichTextBoxAlbum.Size = new System.Drawing.Size(445, 665);
			this.SyncRichTextBoxAlbum.TabIndex = 15;
			this.SyncRichTextBoxAlbum.Text = "";
			this.SyncRichTextBoxAlbum.WordWrap = false;
			// 
			// SyncRichTextBoxTitle
			// 
			this.SyncRichTextBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.SyncRichTextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SyncRichTextBoxTitle.Buddies = null;
			this.SyncRichTextBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SyncRichTextBoxTitle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SyncRichTextBoxTitle.ForeColor = System.Drawing.Color.Yellow;
			this.SyncRichTextBoxTitle.Location = new System.Drawing.Point(711, 68);
			this.SyncRichTextBoxTitle.Name = "SyncRichTextBoxTitle";
			this.SyncRichTextBoxTitle.ReadOnly = true;
			this.SyncRichTextBoxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.SyncRichTextBoxTitle.Size = new System.Drawing.Size(445, 665);
			this.SyncRichTextBoxTitle.TabIndex = 16;
			this.SyncRichTextBoxTitle.Text = "";
			this.SyncRichTextBoxTitle.WordWrap = false;
			// 
			// SyncRichTextBoxPlayCountChange
			// 
			this.SyncRichTextBoxPlayCountChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.SyncRichTextBoxPlayCountChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SyncRichTextBoxPlayCountChange.Buddies = null;
			this.SyncRichTextBoxPlayCountChange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SyncRichTextBoxPlayCountChange.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SyncRichTextBoxPlayCountChange.ForeColor = System.Drawing.Color.Yellow;
			this.SyncRichTextBoxPlayCountChange.Location = new System.Drawing.Point(1162, 68);
			this.SyncRichTextBoxPlayCountChange.Name = "SyncRichTextBoxPlayCountChange";
			this.SyncRichTextBoxPlayCountChange.ReadOnly = true;
			this.SyncRichTextBoxPlayCountChange.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.SyncRichTextBoxPlayCountChange.Size = new System.Drawing.Size(124, 665);
			this.SyncRichTextBoxPlayCountChange.TabIndex = 17;
			this.SyncRichTextBoxPlayCountChange.Text = "";
			this.SyncRichTextBoxPlayCountChange.WordWrap = false;
			// 
			// LabelAllDone
			// 
			this.LabelAllDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelAllDone.AutoSize = true;
			this.tableLayoutPanelMain.SetColumnSpan(this.LabelAllDone, 2);
			this.LabelAllDone.Location = new System.Drawing.Point(669, 13);
			this.LabelAllDone.Name = "LabelAllDone";
			this.LabelAllDone.Size = new System.Drawing.Size(78, 17);
			this.LabelAllDone.TabIndex = 18;
			this.LabelAllDone.Text = "All Done!";
			this.LabelAllDone.Visible = false;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 4;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelMain.Controls.Add(this.SyncRichTextBoxPlayCountChange, 3, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelAllDone, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.SyncRichTextBoxTitle, 2, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelArtist, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.SyncRichTextBoxAlbum, 1, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelAlbum, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.SyncRichTextBoxArtist, 0, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelTitle, 2, 1);
			this.tableLayoutPanelMain.Controls.Add(this.LabelPlayCountChange, 3, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(1286, 733);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1289, 736);
			this.tableLayoutPanelMain.TabIndex = 19;
			// 
			// UpdatePlayCountsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "UpdatePlayCountsScreen";
			this.Size = new System.Drawing.Size(1289, 736);
			this.Enter += new System.EventHandler(this.UpdatePlayCountsScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LabelArtist;
		private System.Windows.Forms.Label LabelAlbum;
		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Label LabelPlayCountChange;
		private SyncRichTextBox SyncRichTextBoxArtist;
		private SyncRichTextBox SyncRichTextBoxAlbum;
		private SyncRichTextBox SyncRichTextBoxTitle;
		private SyncRichTextBox SyncRichTextBoxPlayCountChange;
        private System.Windows.Forms.Label LabelAllDone;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
