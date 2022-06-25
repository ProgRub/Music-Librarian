using Business;
using Business.Commands;
using Business.Commands.ManageLibrary;
using Business.DTOs;

namespace Forms
{
	public partial class EditSongLyricsScreen : BaseControl
	{
		private SongDTO _song;
		public EditSongLyricsScreen()
		{
			InitializeComponent();
		}

		private void EditSongLyricsScreen_Enter(object sender, System.EventArgs e)
		{
			CommandsManager.Instance.Notify += (_, _) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;};
			CommandsManager.Instance.Notify += (_, _) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;};
			_song = BusinessFacade.Instance.GetSongToEditLyrics();
			TextBoxLyrics.Text = _song.Lyrics;
			LabelSongInfo.Text = $"{_song.AlbumArtist} | {_song.Album} | {_song.Title}";
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelMain,false);
		}

		private void ButtonSaveChanges_Click(object sender, System.EventArgs e)
		{
			var auxMacroCommand = new MacroCommandChangeSongsDetails(_song);
			auxMacroCommand.Add(new CommandEditSongLyrics(TextBoxLyrics.Text));
			CommandsManager.Instance.Execute(auxMacroCommand);
		}

		private void ButtonUndo_Click(object sender, System.EventArgs e)
		{
			CommandsManager.Instance.Undo();
			TextBoxLyrics.Text = _song.Lyrics;
		}

		private void ButtonRedo_Click(object sender, System.EventArgs e)
		{
			CommandsManager.Instance.Redo();
			TextBoxLyrics.Text = _song.Lyrics;
		}
	}
}
