using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.Commands;
using Business.DTOs;

namespace Forms
{
	public partial class ManageMusicLibraryScreen : BaseControl
	{
		private ISet<SongDTO> _songs;

		private IDictionary<string, bool> _searchParameters = new Dictionary<string, bool>
		{
			{"Album Artist", false}, {"Album", false}, {"Contributing Artists", false}, {"Song Title", false},
			{"Genre", false}, {"Year", false}, {"Play Count", false}
		};

		public ManageMusicLibraryScreen()
		{
			InitializeComponent();
		}

		private void ButtonEditSelectedSongLyrics_Click(object sender, EventArgs e)
		{
			MoveToScreen(new EditSongLyricsScreen(), this);
		}

		private void ButtonSaveChanges_Click(object sender, EventArgs e)
		{
		}

		private void ManageMusicLibraryScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) =>
			{
				ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;
				ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;
			};
			_songs = BusinessFacade.Instance.GetAllSongs().ToHashSet();
			foreach (var song in _songs)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Undo();
		}

		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			CommandsManager.Instance.Redo();
		}

		private void ListBoxSongFilenames_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetChangeControlsEnabled(ListBoxSongFilenames.SelectedIndices.Count > 0);
			TextBoxChangeFilename.Enabled = ListBoxSongFilenames.SelectedIndices.Count == 1;
			ButtonEditSelectedSongLyrics.Enabled = ListBoxSongFilenames.SelectedIndices.Count == 1;
			if (ListBoxSongFilenames.SelectedIndices.Count > 0)
			{
				FillChangeTextBoxes();
			}
			else
			{
				ClearChangeTextBoxes();
			}
		}

		#region ChangeDetailsTextBoxes

		private void FillChangeTextBoxes()
		{
			ClearChangeTextBoxes();
			if (ListBoxSongFilenames.SelectedIndices.Count == 1)
			{
				TextBoxChangeFilename.Text =
					ListBoxSongFilenames.Items[ListBoxSongFilenames.SelectedIndices[0]].ToString();
			}

			var selectedSongs = new HashSet<SongDTO>();
			foreach (int selectedIndex in ListBoxSongFilenames.SelectedIndices)
			{
				selectedSongs.Add(_songs.First(song =>
					song.Filename == ListBoxSongFilenames.Items[selectedIndex].ToString()));
			}

			var firstSong = selectedSongs.First();
			if (selectedSongs.All(song => song.AlbumArtist == firstSong.AlbumArtist))
			{
				TextBoxChangeAlbumArtist.Text = firstSong.AlbumArtist;
			}

			if (selectedSongs.All(song => Equals(song.ContributingArtists, firstSong.ContributingArtists)))
			{
				TextBoxChangeContributingArtists.Text = string.Join(';', firstSong.ContributingArtists);
			}

			if (selectedSongs.All(song => song.Album == firstSong.Album))
			{
				TextBoxChangeAlbum.Text = firstSong.Album;
			}

			if (selectedSongs.All(song => song.Title == firstSong.Title))
			{
				TextBoxChangeSongTitle.Text = firstSong.Title;
			}

			if (selectedSongs.All(song => song.Genre == firstSong.Genre))
			{
				TextBoxChangeGenre.Text = firstSong.Genre;
			}

			if (selectedSongs.All(song => song.Year == firstSong.Year))
			{
				TextBoxChangeYear.Text = firstSong.Year.ToString();
			}

			if (selectedSongs.All(song => song.TrackNumber == firstSong.TrackNumber))
			{
				TextBoxChangeTrackNumber.Text = firstSong.TrackNumber.ToString();
			}

			if (selectedSongs.All(song => song.DiscNumber == firstSong.DiscNumber))
			{
				TextBoxChangeDiscNumber.Text = firstSong.DiscNumber.ToString();
			}

			if (selectedSongs.All(song => song.PlayCount == firstSong.PlayCount))
			{
				TextBoxChangePlayCount.Text = firstSong.PlayCount.ToString();
			}
		}

		private void ClearChangeTextBoxes()
		{
			ClearTextBox(TextBoxChangeAlbum);
			ClearTextBox(TextBoxChangeAlbumArtist);
			ClearTextBox(TextBoxChangeContributingArtists);
			ClearTextBox(TextBoxChangeDiscNumber);
			ClearTextBox(TextBoxChangeGenre);
			ClearTextBox(TextBoxChangePlayCount);
			ClearTextBox(TextBoxChangeSongTitle);
			ClearTextBox(TextBoxChangeTrackNumber);
			ClearTextBox(TextBoxChangeYear);
			ClearTextBox(TextBoxChangeFilename);
		}

		private void SetChangeControlsEnabled(bool state)
		{
			TextBoxChangeAlbum.Enabled = state;
			TextBoxChangeAlbumArtist.Enabled = state;
			TextBoxChangeContributingArtists.Enabled = state;
			TextBoxChangeDiscNumber.Enabled = state;
			TextBoxChangeGenre.Enabled = state;
			TextBoxChangePlayCount.Enabled = state;
			TextBoxChangeSongTitle.Enabled = state;
			TextBoxChangeTrackNumber.Enabled = state;
			TextBoxChangeYear.Enabled = state;
			ButtonSaveChanges.Enabled = state;
		}

		#endregion

		private bool ContainsIgnoreCase(string container, string inString)
		{
			return container.IndexOf(inString, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		#region SearchTextBoxes

		private void SearchSongs()
		{
			IEnumerable<SongDTO> resultSongs = _songs;
			foreach (var (searchParameter, needToSearch) in _searchParameters)
			{
				if (!needToSearch) continue;
				switch (searchParameter)
				{
					case "Album Artist":
						resultSongs = resultSongs.Where(song =>
							ContainsIgnoreCase(song.AlbumArtist, TextBoxAlbumArtist.Text.Trim()));
						break;
					case "Contributing Artists":
						resultSongs = resultSongs.Where(song => song.ContributingArtists.Any(contributingArtist => ContainsIgnoreCase(contributingArtist, TextBoxContributingArtists.Text.Trim())));
						break;
					case "Album":
						break;
					case "Song Title":
						break;
					case "Genre":
						break;
					case "Year":
						break;
					case "Play Count":
						break;
				}
			}

			ListBoxSongFilenames.Items.Clear();
			foreach (var song in resultSongs)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
		}

		private void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album Artist"] = !string.IsNullOrWhiteSpace(TextBoxAlbumArtist.Text.Trim());
			SearchSongs();
		}

		private void TextBoxContributingArtists_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Contributing Artists"] = !string.IsNullOrWhiteSpace(TextBoxContributingArtists.Text.Trim());
			SearchSongs();
		}

		private void TextBoxAlbum_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album"] = !string.IsNullOrWhiteSpace(TextBoxAlbum.Text.Trim());
			SearchSongs();
		}

		private void TextBoxSongTitle_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Song Title"] = !string.IsNullOrWhiteSpace(TextBoxSongTitle.Text.Trim());
			SearchSongs();
		}

		private void TextBoxGenre_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Genre"] = !string.IsNullOrWhiteSpace(TextBoxGenre.Text.Trim());
			SearchSongs();
		}

		private void TextBoxYear_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Year"] = !string.IsNullOrWhiteSpace(TextBoxYear.Text.Trim());
			SearchSongs();
		}

		private void TextBoxPlayCount_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Play Count"] = !string.IsNullOrWhiteSpace(TextBoxPlayCount.Text.Trim());
			SearchSongs();
		}

		#endregion
	}
}