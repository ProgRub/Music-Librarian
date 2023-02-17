using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.Commands;
using Business.Commands.ManageLibrary;
using Business.Commands.ManageLibrary.ChangeSongDetailsCommands;
using Business.DTOs;
using Business.Enums;
using Forms.Commands;

namespace Forms
{
	public partial class ManageMusicLibraryScreen : BaseControl
	{
		private ISet<SongDTO> _allSongs;
		private ISet<GenreDTO> _genres;
		private int _chosenRating,_songsRating;

		private readonly IDictionary<string, string> _changeTextBoxesContent = new Dictionary<string, string>
		{
			{"Filename", ""}, {"Album Artist", ""}, {"Album", ""}, {"Contributing Artists", ""}, {"Song Title", ""},
			{"Genre", ""}, {"Year", ""}, {"Track Number", ""}, {"Disc Number", ""}, {"Play Count", ""}
		};

		private readonly IDictionary<string, bool> _searchParameters = new Dictionary<string, bool>
		{
			{"Album Artist", false}, {"Album", false}, {"Contributing Artists", false}, {"Song Title", false},
			{"Genre", false}, {"Year", false}, {"Play Count", false}
		};

		private IEnumerable<SongDTO> _songsShownOnListBox;

		public ManageMusicLibraryScreen()
		{
			InitializeComponent();
		}

		private void ButtonEditSelectedSongLyrics_Click(object sender, EventArgs e)
		{
			BusinessFacade.Instance.SetSongToEditLyrics(GetSelectedSongs().First());
			MoveToScreen(new EditSongLyricsScreen(), this);
		}

		private void ButtonSaveChanges_Click(object sender, EventArgs e)
		{
			var executeMacro = false;
			var macroCommand = new MacroCommand();
			if (TextBoxChangeFilename.Enabled)
			{
				var newFilename = TextBoxChangeFilename.Text.Trim();
				if (newFilename != _changeTextBoxesContent["Filename"])
				{
					macroCommand.Add(new CommandRenameSelectedListBoxItem(newFilename, ListBoxSongFilenames));
					macroCommand.Add(new CommandChangeFilename(GetSelectedSongs().First(), newFilename));
					executeMacro = true;
				}
			}

			var macroChangeSongDetailsCommand = new MacroCommandChangeSongsDetails(GetSelectedSongs());
			var newAlbumArtist = TextBoxChangeAlbumArtist.Text.Trim();
			if (newAlbumArtist != _changeTextBoxesContent["Album Artist"])
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeAlbumArtist(newAlbumArtist));
				executeMacro = true;
			}

			var newContributingArtists = TextBoxChangeContributingArtists.Text.Trim();
			if (newContributingArtists != _changeTextBoxesContent["Contributing Artists"])
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeContributingArtists(newContributingArtists));
				executeMacro = true;
			}

			var newAlbum = TextBoxChangeAlbum.Text.Trim();
			if (newAlbum != _changeTextBoxesContent["Album"])
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeSongAlbum(newAlbum));
				executeMacro = true;
			}

			var newSongTitle = TextBoxChangeSongTitle.Text.Trim();
			if (newSongTitle != _changeTextBoxesContent["Song Title"])
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeSongTitle(newSongTitle));
				executeMacro = true;
			}

			var newGenre = TextBoxChangeGenre.Text.Trim();
			if (newGenre != _changeTextBoxesContent["Genre"])
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeSongGenre(newGenre));
				executeMacro = true;
			}

			var newYearText = TextBoxChangeYear.Text.Trim();
			if (newYearText != _changeTextBoxesContent["Year"])
			{
				try
				{
					var commandParameters = GetIntegerDetailsChangeParameters(newYearText);
					var changeType = (IntegerSongDetailsChangeType)commandParameters[0];
					var yearChange = (int)commandParameters[1];
					macroChangeSongDetailsCommand.Add(new CommandChangeSongYear(changeType, yearChange));
					executeMacro = true;
				}
				catch (FormatException)
				{
					ShowInformationMessageBox("You didn't indicate a valid number", "Error");
				}
				catch (ArgumentNullException)
				{
					ShowInformationMessageBox("Wrong format. Needs to be \"+2\" or \"+ 2\", for example", "Error");
				}
				catch (ArgumentOutOfRangeException)
				{
					ShowInformationMessageBox("You didn't indicate a valid operator, check help if you have doubts", "Error");
				}
			}

			var newTrackNumberText = TextBoxChangeTrackNumber.Text.Trim();
			if (newTrackNumberText != _changeTextBoxesContent["Track Number"])
			{
				try
				{
					var commandParameters = GetIntegerDetailsChangeParameters(newTrackNumberText);
					var changeType = (IntegerSongDetailsChangeType)commandParameters[0];
					var trackNumberChange = (int)commandParameters[1];
					macroChangeSongDetailsCommand.Add(new CommandChangeSongTrackNumber(changeType, trackNumberChange));
					executeMacro = true;
				}
				catch (FormatException)
				{
					ShowInformationMessageBox("You didn't indicate a valid number", "Error");
				}
				catch (ArgumentNullException)
				{
					ShowInformationMessageBox("Wrong format. Needs to be \"+2\" or \"+ 2\", for example", "Error");
				}
				catch (ArgumentOutOfRangeException)
				{
					ShowInformationMessageBox("You didn't indicate a valid operator, check help if you have doubts", "Error");
				}
			}

			var newDiscNumberText = TextBoxChangeDiscNumber.Text.Trim();
			if (newDiscNumberText != _changeTextBoxesContent["Disc Number"])
			{
				try
				{
					var commandParameters = GetIntegerDetailsChangeParameters(newDiscNumberText);
					var changeType = (IntegerSongDetailsChangeType)commandParameters[0];
					var discNumberChange = (int)commandParameters[1];
					macroChangeSongDetailsCommand.Add(new CommandChangeSongDiscNumber(changeType, discNumberChange));
					executeMacro = true;
				}
				catch (FormatException)
				{
					ShowInformationMessageBox("You didn't indicate a valid number", "Error");
				}
				catch (ArgumentNullException)
				{
					ShowInformationMessageBox("Wrong format. Needs to be \"+2\" or \"+ 2\", for example", "Error");
				}
				catch (ArgumentOutOfRangeException)
				{
					ShowInformationMessageBox("You didn't indicate a valid operator, check help if you have doubts", "Error");
				}
			}

			var newPlayCountText = TextBoxChangePlayCount.Text.Trim();
			if (newPlayCountText != _changeTextBoxesContent["Play Count"])
			{
				try
				{
					var commandParameters = GetIntegerDetailsChangeParameters(newPlayCountText);
					var changeType = (IntegerSongDetailsChangeType)commandParameters[0];
					var playCountChange = (int)commandParameters[1];
					macroChangeSongDetailsCommand.Add(new CommandChangeSongPlayCount(changeType, playCountChange));
					executeMacro = true;
				}
				catch (FormatException)
				{
					ShowInformationMessageBox("You didn't indicate a valid number", "Error");
				}
				catch (ArgumentNullException)
				{
					ShowInformationMessageBox("Wrong format. Needs to be \"+2\" or \"+ 2\", for example", "Error");
				}
				catch (ArgumentOutOfRangeException)
				{
					ShowInformationMessageBox("You didn't indicate a valid operator, check help if you have doubts", "Error");
				}
			}
			if (_songsRating != _chosenRating)
			{
				macroChangeSongDetailsCommand.Add(new CommandChangeSongRating(_chosenRating));
				executeMacro = true;
			}

			if (executeMacro)
			{
				macroCommand.Add(macroChangeSongDetailsCommand);
				CommandsManager.Instance.Execute(macroCommand);
			}

			FillChangeTextBoxes();
		}

		private object[] GetIntegerDetailsChangeParameters(string text)
		{
			var textSplit = text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			int integerChange;
			IntegerSongDetailsChangeType changeType;
			switch (textSplit.Length)
			{
				case > 2:
					throw new ArgumentNullException();
				case 2:
					{
						var changeOperator = textSplit[0];
						integerChange = int.Parse(textSplit[1]);

						changeType = changeOperator switch
						{
							"+" => IntegerSongDetailsChangeType.Add,
							"-" => IntegerSongDetailsChangeType.Subtract,
							_ => throw new ArgumentOutOfRangeException()
						};

						break;
					}
				default:
					{
						var indexOfFirstNumber = textSplit[0].IndexOfAny("123456789".ToCharArray());
						if (indexOfFirstNumber == -1)
						{
							throw new FormatException();
						}

						var comparisonOperator = textSplit[0][..indexOfFirstNumber];
						integerChange = int.Parse(textSplit[0][indexOfFirstNumber..]);

						switch (comparisonOperator)
						{
							case "+":
								changeType = IntegerSongDetailsChangeType.Add;
								break;
							case "-":
								changeType = IntegerSongDetailsChangeType.Subtract;
								break;
							default:
								if (int.TryParse(textSplit[0], out integerChange))
								{
									changeType = IntegerSongDetailsChangeType.Set;
									integerChange = int.Parse(textSplit[0][indexOfFirstNumber..]);
								}
								else
									throw new FormatException();

								break;
						}

						break;
					}
			}

			return new object[] { changeType, integerChange };
		}

		private void ManageMusicLibraryScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) =>
			{
				ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;
				ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;
			};
			_genres = BusinessFacade.Instance.GetAllGenres().ToHashSet();
			_allSongs = BusinessFacade.Instance.GetAllSongs().ToHashSet();
			SetAutoCompletesOnSearchTextBoxes();
			if (ListBoxSongFilenames.Items.Count > 0) return;
			_songsShownOnListBox = _allSongs;
			foreach (var song in _songsShownOnListBox)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelMain, true);
		}

		private void SetAutoCompletesOnSearchTextBoxes()
		{
			var autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_genres.Select(genre => genre.Name).ToArray());
			TextBoxGenre.AutoCompleteCustomSource = autoCompleteCustomSource;
			TextBoxChangeGenre.AutoCompleteCustomSource = autoCompleteCustomSource;
			autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_allSongs.Select(song => song.AlbumArtist).ToArray());
			TextBoxAlbumArtist.AutoCompleteCustomSource = autoCompleteCustomSource;
			TextBoxContributingArtists.AutoCompleteCustomSource = autoCompleteCustomSource;
			autoCompleteCustomSource = new AutoCompleteStringCollection();
			autoCompleteCustomSource.AddRange(_allSongs.Select(song => song.Album).ToArray());
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

		private ISet<SongDTO> GetSelectedSongs()
		{
			return _allSongs.Where(song => ListBoxSongFilenames.SelectedItems.Contains(song.Filename)).ToHashSet();
		}

		#region ChangeDetailsTextBoxes

		private void FillChangeTextBoxes()
		{
			ClearChangeTextBoxes();
			if (ListBoxSongFilenames.SelectedIndices.Count == 1)
			{
				TextBoxChangeFilename.Text =
					ListBoxSongFilenames.Items[ListBoxSongFilenames.SelectedIndices[0]].ToString();
				_changeTextBoxesContent["Filename"] = TextBoxChangeFilename.Text;
			}

			var selectedSongs = GetSelectedSongs();
			SongDTO firstSong;
			try
			{
				firstSong = selectedSongs.First();
			}
			catch (InvalidOperationException e)
			{
				return;
			}
			
			if (selectedSongs.All(song => song.AlbumArtist == firstSong.AlbumArtist))
			{
				TextBoxChangeAlbumArtist.Text = firstSong.AlbumArtist;
			}

			_changeTextBoxesContent["Album Artist"] = TextBoxChangeAlbumArtist.Text;

			if (selectedSongs.All(song => Equals(song.ContributingArtists, firstSong.ContributingArtists)))
			{
				TextBoxChangeContributingArtists.Text = string.Join(';', firstSong.ContributingArtists);
			}

			_changeTextBoxesContent["Contributing Artists"] = TextBoxChangeContributingArtists.Text;

			if (selectedSongs.All(song => song.Album == firstSong.Album))
			{
				TextBoxChangeAlbum.Text = firstSong.Album;
			}

			_changeTextBoxesContent["Album"] = TextBoxChangeAlbum.Text;

			if (selectedSongs.All(song => song.Title == firstSong.Title))
			{
				TextBoxChangeSongTitle.Text = firstSong.Title;
			}

			_changeTextBoxesContent["Song Title"] = TextBoxChangeSongTitle.Text;

			if (selectedSongs.All(song => song.Genre == firstSong.Genre))
			{
				TextBoxChangeGenre.Text = firstSong.Genre;
			}

			_changeTextBoxesContent["Genre"] = TextBoxChangeGenre.Text;

			if (selectedSongs.All(song => song.Year == firstSong.Year))
			{
				TextBoxChangeYear.Text = firstSong.Year.ToString();
			}

			_changeTextBoxesContent["Year"] = TextBoxChangeYear.Text;

			if (selectedSongs.All(song => song.TrackNumber == firstSong.TrackNumber))
			{
				TextBoxChangeTrackNumber.Text = firstSong.TrackNumber.ToString();
			}

			_changeTextBoxesContent["Track Number"] = TextBoxChangeTrackNumber.Text;

			if (selectedSongs.All(song => song.DiscNumber == firstSong.DiscNumber))
			{
				TextBoxChangeDiscNumber.Text = firstSong.DiscNumber.ToString();
			}

			_changeTextBoxesContent["Disc Number"] = TextBoxChangeDiscNumber.Text;

			if (selectedSongs.All(song => song.PlayCount == firstSong.PlayCount))
			{
				TextBoxChangePlayCount.Text = firstSong.PlayCount.ToString();
			}

			_changeTextBoxesContent["Play Count"] = TextBoxChangePlayCount.Text;

			if (selectedSongs.All(song => song.Rating == firstSong.Rating))
			{
				switch (selectedSongs.First().Rating)
				{
					case 0:
						PictureBoxRating.Image = Properties.Resources.NoRating;
						_songsRating = 0;
						break;
					case 1:
						PictureBoxRating.Image = Properties.Resources._1StarRating;
						_songsRating = 1;
						break;
					case 2:
						PictureBoxRating.Image = Properties.Resources._2StarRating;
						_songsRating = 2;
						break;
					case 3:
						PictureBoxRating.Image = Properties.Resources._3StarRating;
						_songsRating = 3;
						break;
					case 4:
						PictureBoxRating.Image = Properties.Resources._4StarRating;
						_songsRating = 4;
						break;
					case 5:
						PictureBoxRating.Image = Properties.Resources._5StarRating;
						_songsRating = 5;
						break;
				}
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
			PictureBoxRating.Enabled = state;
		}

		#endregion

		private static bool ContainsIgnoreCase(string container, string inString)
		{
			return container.IndexOf(inString, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		#region SearchTextBoxes

		private void SearchSongs()
		{
			_songsShownOnListBox = _allSongs;
			foreach (var (searchParameter, needToSearch) in _searchParameters)
			{
				if (!needToSearch) continue;
				switch (searchParameter)
				{
					case "Album Artist":
						_songsShownOnListBox = _songsShownOnListBox.Where(song =>
							ContainsIgnoreCase(song.AlbumArtist, TextBoxAlbumArtist.Text.Trim()));
						break;
					case "Contributing Artists":
						_songsShownOnListBox = _songsShownOnListBox.Where(song => song.ContributingArtists.Any(contributingArtist =>
							ContainsIgnoreCase(contributingArtist, TextBoxContributingArtists.Text.Trim())));
						break;
					case "Album":
						_songsShownOnListBox = _songsShownOnListBox.Where(song =>
							ContainsIgnoreCase(song.Album, TextBoxAlbum.Text.Trim()));
						break;
					case "Song Title":
						_songsShownOnListBox = _songsShownOnListBox.Where(song =>
							ContainsIgnoreCase(song.Title, TextBoxSongTitle.Text.Trim()));
						break;
					case "Genre":
						_songsShownOnListBox = _songsShownOnListBox.Where(song =>
							ContainsIgnoreCase(song.Genre, TextBoxGenre.Text.Trim()));
						break;
					case "Year":
						_songsShownOnListBox = FilterSongsByYear(_songsShownOnListBox);

						break;
					case "Play Count":
						_songsShownOnListBox = FilterSongsByPlayCount(_songsShownOnListBox);

						break;
				}
			}

			if (_songsShownOnListBox.Count() == ListBoxSongFilenames.Items.Count) return;
			ListBoxSongFilenames.Items.Clear();
			foreach (var song in _songsShownOnListBox)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
			SetFormAcceptButton(ButtonSaveChanges);
		}

		private IEnumerable<SongDTO> FilterSongsByPlayCount(IEnumerable<SongDTO> resultSongs)
		{
			var playCountTextSplit = TextBoxPlayCount.Text.Trim()
				.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			switch (playCountTextSplit.Length)
			{
				case > 2:
					ShowInformationMessageBox("Wrong format. Needs to be \">=2\" or \">= 2\", for example", "Error");
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
									return resultSongs.Where(song => song.PlayCount > playCount);
								case ">=":
									return resultSongs = resultSongs.Where(song => song.PlayCount >= playCount);
								case "<":
									return resultSongs = resultSongs.Where(song => song.PlayCount < playCount);
								case "<=":
									return resultSongs = resultSongs.Where(song => song.PlayCount <= playCount);
								default:
									ShowInformationMessageBox("You didn't indicate a valid comparison operator, check help if you have doubts", "Error");
									break;
							}
						}
						catch (FormatException)
						{
							ShowInformationMessageBox("You didn't indicate a valid play count number", "Error");
						}

						break;
					}
				default:
					{
						var indexOfFirstNumber = playCountTextSplit[0].IndexOfAny("123456789".ToCharArray());
						if (indexOfFirstNumber == -1)
						{
							ShowInformationMessageBox("You didn't indicate a valid play count number", "Error");
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
										return resultSongs = resultSongs.Where(song => song.PlayCount > playCount);
									case ">=":
										return resultSongs = resultSongs.Where(song => song.PlayCount >= playCount);
									case "<":
										return resultSongs = resultSongs.Where(song => song.PlayCount < playCount);
									case "<=":
										return resultSongs = resultSongs.Where(song => song.PlayCount <= playCount);
									default:
										if (int.TryParse(playCountTextSplit[0], out playCount))
										{
											return resultSongs.Where(song =>
												song.PlayCount == playCount);
										}
										ShowInformationMessageBox("You didn't indicate a valid play count number", "Error");
										break;
								}
							}
							catch (FormatException)
							{
								ShowInformationMessageBox("You didn't indicate a valid play count number", "Error");
							}
						}

						break;
					}
			}

			return resultSongs;
		}

		private IEnumerable<SongDTO> FilterSongsByYear(IEnumerable<SongDTO> resultSongs)
		{
			var yearTextSplit = TextBoxYear.Text.Trim()
				.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			switch (yearTextSplit.Length)
			{
				case > 2:
					ShowInformationMessageBox("Wrong format. Needs to be \">2000\" or \"> 2000\", for example", "Error");
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
									return resultSongs = resultSongs.Where(song => song.Year > year);
								case ">=":
									return resultSongs = resultSongs.Where(song => song.Year >= year);
								case "<":
									return resultSongs = resultSongs.Where(song => song.Year < year);
								case "<=":
									return resultSongs = resultSongs.Where(song => song.Year <= year);
								default:
									ShowInformationMessageBox("You didn't indicate a valid comparison operator, check help if you have doubts", "Error");
									break;
							}
						}
						catch (FormatException)
						{
							ShowInformationMessageBox("You didn't indicate a valid year", "Error");
						}

						break;
					}
				default:
					{
						var indexOfFirstNumber = yearTextSplit[0].IndexOfAny("123456789".ToCharArray());
						if (indexOfFirstNumber == -1)
						{
							ShowInformationMessageBox("You didn't indicate a valid year", "Error");
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
										return resultSongs = resultSongs.Where(song => song.Year > year);
									case ">=":
										return resultSongs = resultSongs.Where(song => song.Year >= year);
									case "<":
										return resultSongs = resultSongs.Where(song => song.Year < year);
									case "<=":
										return resultSongs = resultSongs.Where(song => song.Year <= year);
									default:
										if (int.TryParse(yearTextSplit[0], out year))
										{
											return resultSongs = resultSongs.Where(song => song.Year == year);
										}
										ShowInformationMessageBox("You didn't indicate a valid year", "Error");

										break;
								}
							}
							catch (FormatException)
							{
								ShowInformationMessageBox("You didn't indicate a valid year", "Error");
							}
						}

						break;
					}
			}

			return resultSongs;
		}

		private void TextBoxAlbumArtist_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album Artist"] = !string.IsNullOrWhiteSpace(TextBoxAlbumArtist.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxContributingArtists_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Contributing Artists"] =
				!string.IsNullOrWhiteSpace(TextBoxContributingArtists.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxAlbum_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Album"] = !string.IsNullOrWhiteSpace(TextBoxAlbum.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxSongTitle_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Song Title"] = !string.IsNullOrWhiteSpace(TextBoxSongTitle.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxGenre_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Genre"] = !string.IsNullOrWhiteSpace(TextBoxGenre.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxYear_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Year"] = !string.IsNullOrWhiteSpace(TextBoxYear.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		private void TextBoxPlayCount_TextChanged(object sender, EventArgs e)
		{
			_searchParameters["Play Count"] = !string.IsNullOrWhiteSpace(TextBoxPlayCount.Text.Trim());
			SetFormAcceptButton(ButtonSearchLibrary);
		}

		#endregion

		private void ListBoxSongFilenames_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Delete) return;
			var macroCommand = new MacroCommand();
			macroCommand.Add(new CommandDeleteSongs(GetSelectedSongs()));
			macroCommand.Add(new CommandDeleteSelectedListBoxItems(ListBoxSongFilenames));
			CommandsManager.Instance.Execute(macroCommand);
		}

		private void ButtonSearchLibrary_Click(object sender, EventArgs e)
		{
			SearchSongs();
		}

		private void ManageMusicLibraryScreen_Load(object sender, EventArgs e)
		{

		}

		private void comboBoxSortOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBoxSongFilenames.Items.Clear();
			switch (comboBoxSortOrder.Text)
			{
				case "Filename":
					_songsShownOnListBox=_songsShownOnListBox.OrderBy(e => e.Filename);
					break;
				case "Track Number":
					_songsShownOnListBox = _songsShownOnListBox.OrderBy(e => e.DiscNumber).ThenBy(e=> e.TrackNumber );
					break;
				case "Album Artist":
					_songsShownOnListBox = _songsShownOnListBox.OrderBy(e => e.AlbumArtist);
					break;
				case "Year":
					_songsShownOnListBox = _songsShownOnListBox.OrderBy(e => e.Year);
					break;
				case "Album":
					_songsShownOnListBox = _songsShownOnListBox.OrderBy(e => e.Album);
					break;
				case "Genre":
					_songsShownOnListBox = _songsShownOnListBox.OrderBy(e => e.Genre);
					break;
			}

			foreach (var song in _songsShownOnListBox)
			{
				ListBoxSongFilenames.Items.Add(song.Filename);
			}
		}

		private void pictureBoxRating_Click(object sender, EventArgs e)
		{
			MouseEventArgs e2 = (MouseEventArgs)e;
			double positionRatio = e2.X / (double)PictureBoxRating.Size.Width;
			if (positionRatio < 0.2)
			{
				if (_chosenRating==1)
				{
					PictureBoxRating.Image = Properties.Resources.NoRating;
					_chosenRating = 0;
				}
				else
				{
					PictureBoxRating.Image = Properties.Resources._1StarRating;
					_chosenRating = 1;
				}
			}
			else if (positionRatio < 0.4)
			{
				PictureBoxRating.Image = Properties.Resources._2StarRating;
				_chosenRating = 2;
			}
			else if (positionRatio < 0.6)
			{
				PictureBoxRating.Image = Properties.Resources._3StarRating;
				_chosenRating = 3;
			}
			else if (positionRatio < 0.8)
			{
				PictureBoxRating.Image = Properties.Resources._4StarRating;
				_chosenRating = 4;
			}
			else
			{
				PictureBoxRating.Image = Properties.Resources._5StarRating;
				_chosenRating = 5;
			}
		}
	}
}