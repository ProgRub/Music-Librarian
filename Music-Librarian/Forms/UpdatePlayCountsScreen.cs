using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Business;
using Business.CustomEventArgs;

namespace Forms
{
	public partial class UpdatePlayCountsScreen : BaseControl
	{
		private int _numberOfWrittenLines;
		private readonly object _mutex=new();
		private readonly UpdatePlayCountsType _type;
		private int _songsProcessed;
		private int _songsTotal;

		public UpdatePlayCountsScreen(UpdatePlayCountsType type)
		{
			InitializeComponent();
			_type = type;
			var buddies = new Control[] {SyncRichTextBoxAlbum, SyncRichTextBoxTitle, SyncRichTextBoxPlayCountChange};
			SyncRichTextBoxArtist.Buddies = buddies;
			buddies = new Control[] {SyncRichTextBoxArtist, SyncRichTextBoxTitle, SyncRichTextBoxPlayCountChange};
			SyncRichTextBoxAlbum.Buddies = buddies;
			buddies = new Control[] {SyncRichTextBoxArtist, SyncRichTextBoxAlbum, SyncRichTextBoxPlayCountChange};
			SyncRichTextBoxTitle.Buddies = buddies;
			buddies = new Control[] {SyncRichTextBoxArtist, SyncRichTextBoxAlbum, SyncRichTextBoxTitle};
			SyncRichTextBoxPlayCountChange.Buddies = buddies;
			_numberOfWrittenLines = 0;
            _songsProcessed = 0;
        }

		private void UpdatePlayCountsScreen_Enter(object sender, EventArgs e)
		{
			BusinessFacade.Instance.NotifyUpdatePlayCounts += (_, args) =>
			{
				lock (_mutex)
				{
					AddSongToTextBoxes(args);
				}
			};
			if (_type == UpdatePlayCountsType.UpdatePlayCountsFromMusicService)
			{
				BusinessFacade.Instance.UpdateDatabasePlayCounts();
			}
			else
			{
				BusinessFacade.Instance.SetMusicServicePlayCountsBasedOnDatabase();
			}
			_songsTotal = BusinessFacade.Instance.GetNumberOfSongs();
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelMain,true);
		}

		private void AddSongToTextBoxes(UpdatePlayCountEventArgs eventArgs)
		{
			var textColor = Color.Yellow;
			if (eventArgs.NewPlayCount > eventArgs.OldPlayCount)
			{
				textColor = Color.LimeGreen;
			}
			else if (eventArgs.NewPlayCount < eventArgs.OldPlayCount)
			{
				textColor = Color.Red;
			}

			var newLineBeforeText = _numberOfWrittenLines > 0;
			SyncRichTextBoxArtist.Invoke(new MethodInvoker(delegate
			{
				SyncRichTextBoxArtist.AppendText(
					$"{(newLineBeforeText ? Environment.NewLine : "")}{eventArgs.Song.AlbumArtist}");
				SyncRichTextBoxArtist.Select(SyncRichTextBoxArtist.GetFirstCharIndexFromLine(_numberOfWrittenLines),
					SyncRichTextBoxArtist.Lines[_numberOfWrittenLines].Length);
				SyncRichTextBoxArtist.SelectionColor = textColor;
				SyncRichTextBoxArtist.ScrollToCaret();
			}));
			SyncRichTextBoxAlbum.Invoke(new MethodInvoker(delegate
			{
				SyncRichTextBoxAlbum.AppendText(
					$"{(newLineBeforeText ? Environment.NewLine : "")}{eventArgs.Song.Album}");
				SyncRichTextBoxAlbum.Select(SyncRichTextBoxAlbum.GetFirstCharIndexFromLine(_numberOfWrittenLines),
					SyncRichTextBoxAlbum.Lines[_numberOfWrittenLines].Length);
				SyncRichTextBoxAlbum.SelectionColor = textColor;
				SyncRichTextBoxAlbum.ScrollToCaret();
			}));
			SyncRichTextBoxTitle.Invoke(new MethodInvoker(delegate
			{
				SyncRichTextBoxTitle.AppendText(
					$"{(newLineBeforeText ? Environment.NewLine : "")}{eventArgs.Song.Title}");
				SyncRichTextBoxTitle.Select(SyncRichTextBoxTitle.GetFirstCharIndexFromLine(_numberOfWrittenLines),
					SyncRichTextBoxTitle.Lines[_numberOfWrittenLines].Length);
				SyncRichTextBoxTitle.SelectionColor = textColor;
				SyncRichTextBoxTitle.ScrollToCaret();
			}));
			SyncRichTextBoxPlayCountChange.Invoke(new MethodInvoker(delegate
			{
				SyncRichTextBoxPlayCountChange.AppendText(
					$"{(newLineBeforeText ? Environment.NewLine : "")}{eventArgs.OldPlayCount} ---> {eventArgs.NewPlayCount}");
				SyncRichTextBoxPlayCountChange.Select(
					SyncRichTextBoxPlayCountChange.GetFirstCharIndexFromLine(_numberOfWrittenLines),
					SyncRichTextBoxPlayCountChange.Lines[_numberOfWrittenLines].Length);
				SyncRichTextBoxPlayCountChange.SelectionColor = textColor;
				SyncRichTextBoxPlayCountChange.ScrollToCaret();
			}));
			_numberOfWrittenLines++;
            _songsProcessed++;
            if (_songsProcessed == _songsTotal)
            {
                LabelAllDone.Invoke(new MethodInvoker(delegate { LabelAllDone.Visible = true; }));
            }
        }
	}
}