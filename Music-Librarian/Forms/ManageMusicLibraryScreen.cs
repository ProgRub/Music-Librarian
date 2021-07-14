using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.Commands;
using Business.DTOs;
using DB.Entities;

namespace Forms
{
	public partial class ManageMusicLibraryScreen : BaseControl
	{
		private const int SearchDelay = 500;
		private ISet<SongDTO> _songs;
		private ISet<GenreDTO> _genres;
		private Timer _searchTimer;

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
			_genres = BusinessFacade.Instance.GetAllGenres().ToHashSet();
			_songs = BusinessFacade.Instance.GetAllSongs().ToHashSet();
			SetAutoCompletesOnSearchTextBoxes();
			foreach (var song in _songs)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
		}

		private void SetAutoCompletesOnSearchTextBoxes()
		{
			var autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_genres.Select(genre => genre.Name).ToArray());
			TextBoxGenre.AutoCompleteCustomSource = autoCompleteCustomSource;
			autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_songs.Select(song => song.AlbumArtist).ToArray());
			TextBoxAlbumArtist.AutoCompleteCustomSource = autoCompleteCustomSource;
			TextBoxContributingArtists.AutoCompleteCustomSource = autoCompleteCustomSource;
			autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_songs.Select(song => song.Album).ToArray());
			TextBoxAlbum.AutoCompleteCustomSource = autoCompleteCustomSource;
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

		private static bool ContainsIgnoreCase(string container, string inString)
		{
			return container.IndexOf(inString, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		#region SearchTextBoxes

		private void Delay(int milliseconds, EventHandler action)
		{
			if (_searchTimer is {Enabled: true}) _searchTimer.Enabled = false;
			_searchTimer = new Timer {Interval = milliseconds};
			_searchTimer.Tick += (_, _) => _searchTimer.Enabled = false;
			_searchTimer.Tick += action;
			_searchTimer.Enabled = true;
		}

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
						resultSongs = resultSongs.Where(song => song.ContributingArtists.Any(contributingArtist =>
							ContainsIgnoreCase(contributingArtist, TextBoxContributingArtists.Text.Trim())));
						break;
					case "Album":
						resultSongs = resultSongs.Where(song =>
							ContainsIgnoreCase(song.Album, TextBoxAlbum.Text.Trim()));
						break;
					case "Song Title":
						resultSongs = resultSongs.Where(song =>
							ContainsIgnoreCase(song.Title, TextBoxSongTitle.Text.Trim()));
						break;
					case "Genre":
						resultSongs = resultSongs.Where(song =>
							ContainsIgnoreCase(song.Genre, TextBoxGenre.Text.Trim()));
						break;
					case "Year":
						var yearTextSplit = TextBoxYear.Text.Trim()
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
						switch (yearTextSplit.Length)
						{
							case > 2:
								ShowTextBoxErrorMessage(TextBoxYear,
									"Wrong format. Needs to be \">2000\" or \"> 2000\", for example");
								break;
							case 2:
							{
								var comparisonOperator = yearTextSplit[0];
								try
								{
									var year = int.Parse(yearTextSplit[1]);

									switch (comparisonOperator)
									{
										case ">":
											resultSongs = resultSongs.Where(song => song.Year > year);
											break;
										case ">=":
											resultSongs = resultSongs.Where(song => song.Year >= year);
											break;
										case "<":
											resultSongs = resultSongs.Where(song => song.Year < year);
											break;
										case "<=":
											resultSongs = resultSongs.Where(song => song.Year <= year);
											break;
										default:
											ShowTextBoxErrorMessage(TextBoxYear,
												"You didn't indicate a valid comparison operator, check help if you have doubts");
											break;
									}
								}
								catch (FormatException)
								{
									ShowTextBoxErrorMessage(TextBoxYear, "You didn't indicate a valid year");
								}

								break;
							}
							default:
							{
								var indexOfFirstNumber = yearTextSplit[0].IndexOfAny("123456789".ToCharArray());
								if (indexOfFirstNumber == -1)
								{
									ShowTextBoxErrorMessage(TextBoxYear, "You didn't indicate a valid year");
								}
								else
								{
									var comparisonOperator = yearTextSplit[0][..indexOfFirstNumber];
									try
									{
										var year = int.Parse(yearTextSplit[0][indexOfFirstNumber..]);

										switch (comparisonOperator)
										{
											case ">":
												resultSongs = resultSongs.Where(song => song.Year > year);
												break;
											case ">=":
												resultSongs = resultSongs.Where(song => song.Year >= year);
												break;
											case "<":
												resultSongs = resultSongs.Where(song => song.Year < year);
												break;
											case "<=":
												resultSongs = resultSongs.Where(song => song.Year <= year);
												break;
											default:
												if (int.TryParse(yearTextSplit[0], out year))
												{
													resultSongs = resultSongs.Where(song => song.Year == year);
												}
												else
												{
													ShowTextBoxErrorMessage(TextBoxYear,
														"You didn't indicate a valid year");
												}

												break;
										}
									}
									catch (FormatException)
									{
										ShowTextBoxErrorMessage(TextBoxYear, "You didn't indicate a valid year");
									}
								}

								break;
							}
						}

						break;
					case "Play Count":
						var playCountTextSplit = TextBoxPlayCount.Text.Trim()
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
						switch (playCountTextSplit.Length)
						{
							case > 2:
								ShowTextBoxErrorMessage(TextBoxPlayCount,
									"Wrong format. Needs to be \">=2\" or \">= 2\", for example");
								break;
							case 2:
							{
								var comparisonOperator = playCountTextSplit[0];
								try
								{
									var playCount = int.Parse(playCountTextSplit[1]);

									switch (comparisonOperator)
									{
										case ">":
											resultSongs = resultSongs.Where(song => song.PlayCount > playCount);
											break;
										case ">=":
											resultSongs = resultSongs.Where(song => song.PlayCount >= playCount);
											break;
										case "<":
											resultSongs = resultSongs.Where(song => song.PlayCount < playCount);
											break;
										case "<=":
											resultSongs = resultSongs.Where(song => song.PlayCount <= playCount);
											break;
										default:
											ShowTextBoxErrorMessage(TextBoxPlayCount,
												"You didn't indicate a valid comparison operator, check help if you have doubts");
											break;
									}
								}
								catch (FormatException)
								{
									ShowTextBoxErrorMessage(TextBoxPlayCount,
										"You didn't indicate a valid play count number");
								}

								break;
							}
							default:
							{
								var indexOfFirstNumber = playCountTextSplit[0].IndexOfAny("123456789".ToCharArray());
								if (indexOfFirstNumber == -1)
								{
									ShowTextBoxErrorMessage(TextBoxPlayCount,
										"You didn't indicate a valid play count number");
								}
								else
								{
									var comparisonOperator = playCountTextSplit[0][..indexOfFirstNumber];
									try
									{
										var playCount = int.Parse(playCountTextSplit[0][indexOfFirstNumber..]);

										switch (comparisonOperator)
										{
											case ">":
												resultSongs = resultSongs.Where(song => song.PlayCount > playCount);
												break;
											case ">=":
												resultSongs = resultSongs.Where(song => song.PlayCount >= playCount);
												break;
											case "<":
												resultSongs = resultSongs.Where(song => song.PlayCount < playCount);
												break;
											case "<=":
												resultSongs = resultSongs.Where(song => song.PlayCount <= playCount);
												break;
											default:
												if (int.TryParse(playCountTextSplit[0], out playCount))
												{
													resultSongs = resultSongs.Where(song => song.PlayCount == playCount);
												}
												else
												{
													ShowTextBoxErrorMessage(TextBoxPlayCount,
														"You didn't indicate a valid play count number");
												}

												break;
										}
									}
									catch (FormatException)
									{
										ShowTextBoxErrorMessage(TextBoxPlayCount,
											"You didn't indicate a valid play count number");
									}
								}

								break;
							}
						}

						break;
				}
			}

			if (resultSongs.Count() == ListBoxSongFilenames.Items.Count) return;
			ListBoxSongFilenames.Items.Clear();
			foreach (var song in resultSongs)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
		}

		private void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album Artist"] = !string.IsNullOrWhiteSpace(TextBoxAlbumArtist.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxContributingArtists_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Contributing Artists"] =
				!string.IsNullOrWhiteSpace(TextBoxContributingArtists.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxAlbum_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album"] = !string.IsNullOrWhiteSpace(TextBoxAlbum.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxSongTitle_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Song Title"] = !string.IsNullOrWhiteSpace(TextBoxSongTitle.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxGenre_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Genre"] = !string.IsNullOrWhiteSpace(TextBoxGenre.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxYear_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Year"] = !string.IsNullOrWhiteSpace(TextBoxYear.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		private void TextBoxPlayCount_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Play Count"] = !string.IsNullOrWhiteSpace(TextBoxPlayCount.Text.Trim());
			Delay(SearchDelay, (_, _) => SearchSongs());
		}

		#endregion

		private void TextBoxYear_Click(object sender, EventArgs e)
		{
			TextBoxYear.PlaceholderText = "";
		}

		private void TextBoxPlayCount_Click(object sender, EventArgs e)
		{
			TextBoxPlayCount.PlaceholderText = "";
		}
	}
}