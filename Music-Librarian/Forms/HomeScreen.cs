using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

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
	}
}
