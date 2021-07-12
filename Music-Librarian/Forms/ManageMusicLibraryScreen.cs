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
using Business.Commands;
using Business.DTOs;

namespace Forms
{
	public partial class ManageMusicLibraryScreen : BaseControl
	{
		private ISet<SongDTO> _songs;
		public ManageMusicLibraryScreen()
		{
			InitializeComponent();
		}

		private void ButtonEditSelectedSongLyrics_Click(object sender, EventArgs e)
		{
			MoveToScreen(new EditSongLyricsScreen(),this);
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
	}
}
