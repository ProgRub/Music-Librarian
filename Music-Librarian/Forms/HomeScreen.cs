using System;
using System.Windows.Forms;
using Business;
using Business.Commands;

namespace Forms
{
	public partial class HomeScreen : BaseControl
	{
		private string _musicToDirectory;
		public HomeScreen()
		{
			InitializeComponent();
		}

		private void HomeScreen_Enter(object sender, EventArgs e)
		{
			CommandsManager.Instance.ResetCommandsList();
			_musicToDirectory = BusinessFacade.Instance.GetMusicLibraryDirectory();
			TextBoxDirectory.Text = _musicToDirectory;
		}

		private void ButtonChooseFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog.Description = "Pick the folder where you store your music";
			var dialogResult = FolderBrowserDialog.ShowDialog();

			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(FolderBrowserDialog.SelectedPath)) return;
			_musicToDirectory = FolderBrowserDialog.SelectedPath;
			TextBoxDirectory.Text = _musicToDirectory;
			BusinessFacade.Instance.SetMusicLibraryDirectory(_musicToDirectory);
		}

		private void ButtonManageGenres_Click(object sender, EventArgs e)
		{
			MoveToScreen(new ManageGenresAndColorsScreen(),this);
		}

		private void ButtonChooseAlbum_Click(object sender, EventArgs e)
		{
			MoveToScreen(new SetAlbumPropertiesScreen(),this);
		}

		private void ButtonSearchLibrary_Click(object sender, EventArgs e)
		{
			MoveToScreen(new ManageMusicLibraryScreen(),this);
		}

		private void ButtonUpdatePlayCounts_Click(object sender, EventArgs e)
		{
			MoveToScreen(new UpdatePlayCountsScreen(UpdatePlayCountsType.UpdatePlayCountsFromMusicService),this);
		}

		private void ButtonSetPlayCountsFromDB_Click(object sender, EventArgs e)
		{
			MoveToScreen(new UpdatePlayCountsScreen(UpdatePlayCountsType.SetMusicServicePlayCountsFromDB),this);
		}
	}
}
