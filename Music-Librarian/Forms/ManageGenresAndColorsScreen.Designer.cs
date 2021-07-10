
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
			this.TextBoxDirectory = new System.Windows.Forms.TextBox();
			this.ButtonSaveChanges = new System.Windows.Forms.Button();
			this.ColorPicker = new System.Windows.Forms.ColorDialog();
			this.LabelGenreName = new System.Windows.Forms.Label();
			this.ButtonPickColor = new System.Windows.Forms.Button();
			this.ListBoxGenres = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// TextBoxDirectory
			// 
			this.TextBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDirectory.Location = new System.Drawing.Point(117, 47);
			this.TextBoxDirectory.Name = "TextBoxDirectory";
			this.TextBoxDirectory.ReadOnly = true;
			this.TextBoxDirectory.Size = new System.Drawing.Size(289, 24);
			this.TextBoxDirectory.TabIndex = 8;
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
			this.ButtonSaveChanges.Location = new System.Drawing.Point(200, 110);
			this.ButtonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonSaveChanges.Name = "ButtonSaveChanges";
			this.ButtonSaveChanges.Size = new System.Drawing.Size(127, 27);
			this.ButtonSaveChanges.TabIndex = 10;
			this.ButtonSaveChanges.Text = "Save Changes";
			this.ButtonSaveChanges.UseVisualStyleBackColor = false;
			// 
			// LabelGenreName
			// 
			this.LabelGenreName.AutoSize = true;
			this.LabelGenreName.Location = new System.Drawing.Point(9, 49);
			this.LabelGenreName.Name = "LabelGenreName";
			this.LabelGenreName.Size = new System.Drawing.Size(102, 17);
			this.LabelGenreName.TabIndex = 11;
			this.LabelGenreName.Text = "Genre Name";
			// 
			// ButtonPickColor
			// 
			this.ButtonPickColor.AutoSize = true;
			this.ButtonPickColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPickColor.BackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatAppearance.BorderSize = 0;
			this.ButtonPickColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonPickColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonPickColor.ForeColor = System.Drawing.Color.White;
			this.ButtonPickColor.Location = new System.Drawing.Point(175, 77);
			this.ButtonPickColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ButtonPickColor.Name = "ButtonPickColor";
			this.ButtonPickColor.Size = new System.Drawing.Size(177, 27);
			this.ButtonPickColor.TabIndex = 12;
			this.ButtonPickColor.Text = "Pick the Genre Color";
			this.ButtonPickColor.UseVisualStyleBackColor = false;
			this.ButtonPickColor.Click += new System.EventHandler(this.ButtonPickColor_Click);
			// 
			// ListBoxGenres
			// 
			this.ListBoxGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ListBoxGenres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListBoxGenres.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListBoxGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ListBoxGenres.FormattingEnabled = true;
			this.ListBoxGenres.ItemHeight = 16;
			this.ListBoxGenres.Location = new System.Drawing.Point(429, 47);
			this.ListBoxGenres.Name = "ListBoxGenres";
			this.ListBoxGenres.Size = new System.Drawing.Size(270, 242);
			this.ListBoxGenres.TabIndex = 13;
			this.ListBoxGenres.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenres_SelectedIndexChanged);
			// 
			// ManageGenresAndColorsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ListBoxGenres);
			this.Controls.Add(this.ButtonPickColor);
			this.Controls.Add(this.LabelGenreName);
			this.Controls.Add(this.ButtonSaveChanges);
			this.Controls.Add(this.TextBoxDirectory);
			this.Name = "ManageGenresAndColorsScreen";
			this.Enter += new System.EventHandler(this.ManageGenresAndColorsScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.TextBoxDirectory, 0);
			this.Controls.SetChildIndex(this.ButtonSaveChanges, 0);
			this.Controls.SetChildIndex(this.LabelGenreName, 0);
			this.Controls.SetChildIndex(this.ButtonPickColor, 0);
			this.Controls.SetChildIndex(this.ListBoxGenres, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxDirectory;
		private System.Windows.Forms.Button ButtonSaveChanges;
		private System.Windows.Forms.ColorDialog ColorPicker;
		private System.Windows.Forms.Label LabelGenreName;
		private System.Windows.Forms.Button ButtonPickColor;
		private System.Windows.Forms.ListBox ListBoxGenres;
	}
}
