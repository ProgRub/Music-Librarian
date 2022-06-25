
namespace Forms
{
	partial class ManageGenresAndColorsScreen
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
			this.TextBoxGenreName = new System.Windows.Forms.TextBox();
			this.ButtonSaveChanges = new System.Windows.Forms.Button();
			this.ColorPicker = new System.Windows.Forms.ColorDialog();
			this.LabelGenreName = new System.Windows.Forms.Label();
			this.ButtonPickColor = new System.Windows.Forms.Button();
			this.ListBoxGenres = new System.Windows.Forms.ListBox();
			this.ButtonUndo = new System.Windows.Forms.Button();
			this.ButtonRedo = new System.Windows.Forms.Button();
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
			// TextBoxGenreName
			// 
			this.TextBoxGenreName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxGenreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxGenreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxGenreName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxGenreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxGenreName.Location = new System.Drawing.Point(113, 33);
			this.TextBoxGenreName.Name = "TextBoxGenreName";
			this.TextBoxGenreName.Size = new System.Drawing.Size(325, 24);
			this.TextBoxGenreName.TabIndex = 8;
			// 
			// ButtonSaveChanges
			// 
			this.ButtonSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonSaveChanges.AutoSize = true;
			this.ButtonSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSaveChanges.BackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.BorderSize = 0;
			this.ButtonSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSaveChanges.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonSaveChanges.Location = new System.Drawing.Point(212, 95);
			this.ButtonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonSaveChanges.Name = "ButtonSaveChanges";
			this.ButtonSaveChanges.Size = new System.Drawing.Size(127, 25);
			this.ButtonSaveChanges.TabIndex = 10;
			this.ButtonSaveChanges.Text = "Save Changes";
			this.ButtonSaveChanges.UseVisualStyleBackColor = false;
			this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
			// 
			// LabelGenreName
			// 
			this.LabelGenreName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelGenreName.AutoSize = true;
			this.LabelGenreName.Location = new System.Drawing.Point(5, 37);
			this.LabelGenreName.Name = "LabelGenreName";
			this.LabelGenreName.Size = new System.Drawing.Size(102, 17);
			this.LabelGenreName.TabIndex = 11;
			this.LabelGenreName.Text = "Genre Name";
			// 
			// ButtonPickColor
			// 
			this.ButtonPickColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonPickColor.AutoSize = true;
			this.ButtonPickColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPickColor.BackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatAppearance.BorderSize = 0;
			this.ButtonPickColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonPickColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonPickColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonPickColor.Location = new System.Drawing.Point(187, 64);
			this.ButtonPickColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonPickColor.Name = "ButtonPickColor";
			this.ButtonPickColor.Size = new System.Drawing.Size(177, 25);
			this.ButtonPickColor.TabIndex = 12;
			this.ButtonPickColor.Text = "Pick the Genre Color";
			this.ButtonPickColor.UseVisualStyleBackColor = false;
			this.ButtonPickColor.Click += new System.EventHandler(this.ButtonPickColor_Click);
			// 
			// ListBoxGenres
			// 
			this.ListBoxGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ListBoxGenres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanelMain.SetColumnSpan(this.ListBoxGenres, 2);
			this.ListBoxGenres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListBoxGenres.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListBoxGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ListBoxGenres.FormattingEnabled = true;
			this.ListBoxGenres.ItemHeight = 16;
			this.ListBoxGenres.Location = new System.Drawing.Point(444, 33);
			this.ListBoxGenres.Name = "ListBoxGenres";
			this.tableLayoutPanelMain.SetRowSpan(this.ListBoxGenres, 4);
			this.ListBoxGenres.Size = new System.Drawing.Size(289, 150);
			this.ListBoxGenres.TabIndex = 13;
			this.ListBoxGenres.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenres_SelectedIndexChanged);
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
			this.ButtonUndo.Location = new System.Drawing.Point(562, 189);
			this.ButtonUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonUndo.Name = "ButtonUndo";
			this.ButtonUndo.Size = new System.Drawing.Size(22, 22);
			this.ButtonUndo.TabIndex = 14;
			this.ButtonUndo.UseVisualStyleBackColor = false;
			this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
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
			this.ButtonRedo.Location = new System.Drawing.Point(592, 189);
			this.ButtonRedo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonRedo.Name = "ButtonRedo";
			this.ButtonRedo.Size = new System.Drawing.Size(22, 22);
			this.ButtonRedo.TabIndex = 15;
			this.ButtonRedo.UseVisualStyleBackColor = false;
			this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 4;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.Controls.Add(this.ButtonUndo, 2, 5);
			this.tableLayoutPanelMain.Controls.Add(this.ListBoxGenres, 2, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonRedo, 3, 5);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonSaveChanges, 1, 3);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonPickColor, 1, 2);
			this.tableLayoutPanelMain.Controls.Add(this.LabelGenreName, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.TextBoxGenreName, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(731, 213);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 6;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(736, 218);
			this.tableLayoutPanelMain.TabIndex = 16;
			// 
			// ManageGenresAndColorsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "ManageGenresAndColorsScreen";
			this.Size = new System.Drawing.Size(736, 218);
			this.Enter += new System.EventHandler(this.ManageGenresAndColorsScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxGenreName;
		private System.Windows.Forms.Button ButtonSaveChanges;
		private System.Windows.Forms.ColorDialog ColorPicker;
		private System.Windows.Forms.Label LabelGenreName;
		private System.Windows.Forms.Button ButtonPickColor;
		private System.Windows.Forms.ListBox ListBoxGenres;
		private System.Windows.Forms.Button ButtonUndo;
		private System.Windows.Forms.Button ButtonRedo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
