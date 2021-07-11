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
	public partial class AlbumTrackListScreen : BaseControl
	{
		private AlbumDTO _album;
		public AlbumTrackListScreen()
		{
			InitializeComponent();
		}

		private void AlbumTrackListScreen_Enter(object sender, EventArgs e)
		{
			_album = BusinessFacade.Instance.GetSelectedAlbum();
			foreach (var song in _album.Songs)
			{
				Debug.WriteLine($"{song.TrackNumber}. {song.Title}");
			}
			LabelArtistAndAlbumTitle.Text =
				LabelArtistAndAlbumTitle.Text.Replace("x", _album.Artist).Replace("y", _album.Title);
			PictureBoxAlbumCover.Image =
				Image.FromStream(BusinessFacade.Instance.GetAlbumArtworkMemoryStream(_album.Songs.First()));
			var addToTrackNumber = 0;
			for (var discNumber = 1; discNumber <= _album.TotalDiscCount; discNumber++)
			{
				var discTracks = _album.Songs.Where(song=>song.DiscNumber==discNumber).OrderBy(song=>song.TrackNumber);
				foreach (var song in discTracks)
				{
					TextBoxTrackList.AppendText($"{song.TrackNumber+addToTrackNumber}. {song.Title}{Environment.NewLine}");
				}

				addToTrackNumber += discTracks.Last().TrackNumber;
			}
			TextBoxTrackList.Text = TextBoxTrackList.Text.Trim();
			TextBoxTrackList.Height = TextBoxTrackList.Font.Height * _album.Songs.Count() + (TextBoxTrackList.Height - TextBoxTrackList.ClientSize.Height);
		}

		private void ButtonShowAlbumOnService_Click(object sender, EventArgs e)
		{
			BusinessFacade.Instance.OpenAlbumOnService(_album);
		}
	}
}
