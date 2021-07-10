using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.DTOs;

namespace Forms
{
	public partial class ManageGenresAndColorsScreen : BaseControl
	{
		private ICollection<GenreDTO> _genres;
		public ManageGenresAndColorsScreen()
		{
			InitializeComponent();
		}

		private void ButtonPickColor_Click(object sender, EventArgs e)
		{
			if(ColorPicker.ShowDialog()!=DialogResult.OK)return;
			ButtonPickColor.ForeColor = ColorPicker.Color;
		}

		private void ListBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ManageGenresAndColorsScreen_Enter(object sender, EventArgs e)
		{
			//_genres = BusinessFacade.Instance.GetAllGenres().ToList();
		}
	}
}
