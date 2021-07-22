using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.Commands;
using Business.Commands.ManageGenres;
using Business.DTOs;
using Forms.Commands;

namespace Forms
{
	public partial class ManageGenresAndColorsScreen : BaseControl
	{
		private IList<GenreDTO> _genres;
		private GenreDTO _selectedGenre;

		public ManageGenresAndColorsScreen()
		{
			InitializeComponent();
		}

		private void ButtonPickColor_Click(object sender, EventArgs e)
		{
			if (ColorPicker.ShowDialog() != DialogResult.OK) return;
			ButtonPickColor.ForeColor = ColorPicker.Color;
		}

		private void ListBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ListBoxGenres.SelectedIndex < 0)
			{
				_selectedGenre = null;
				ClearTextBox(TextBoxGenreName);
				ButtonPickColor.ForeColor = Color.FromArgb(255, 255, 128);
				return;
			}

			GetSelectedGenre();
			ShowNameAndColorOfSelectedGenre();
		}

		private void ShowNameAndColorOfSelectedGenre()
		{
			if (_selectedGenre == null) return;
			TextBoxGenreName.Text = _selectedGenre.Name;
			ButtonPickColor.ForeColor = _selectedGenre.Color;
		}

		private void GetSelectedGenre()
		{
			_selectedGenre = GetGenreFromString(ListBoxGenres.Items[ListBoxGenres.SelectedIndex].ToString());
		}

		private void ManageGenresAndColorsScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo; };
			CommandsManager.Instance.Notify += (_, _) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo; };
			_genres = BusinessFacade.Instance.GetAllGenres().ToList();
			foreach (var genre in _genres)
			{
				ListBoxGenres.Items.Add($"{genre.Id} | {genre.Name}");
			}
		}

		private GenreDTO GetGenreFromString(string genre) =>
			_genres.First(e => e.Id.ToString() == genre.Split(" | ").First());

		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Redo();
			GetSelectedGenre();
			ShowNameAndColorOfSelectedGenre();
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Undo();
			GetSelectedGenre();
			ShowNameAndColorOfSelectedGenre();
		}

		private void ButtonSaveChanges_Click(object sender, EventArgs e)
		{
			var macro = new MacroCommand();
			macro.Add(new CommandChangeGenre(_selectedGenre, TextBoxGenreName.Text, ButtonPickColor.ForeColor,
				ref _genres));
			macro.Add(new CommandRenameSelectedListBoxItem($"{_selectedGenre.Id} | {TextBoxGenreName.Text}",
				ListBoxGenres));
			CommandsManager.Instance.Execute(macro);
		}
	}
}