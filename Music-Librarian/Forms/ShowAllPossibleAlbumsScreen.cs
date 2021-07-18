using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.DTOs;

namespace Forms
{
	public partial class ShowAllPossibleAlbumsScreen : BaseControl
	{
		private IEnumerable<AlbumDTO> _albums;
		private string _timeSpanFormat;
		private ListViewColumnSorter _columnSorter;

		public ShowAllPossibleAlbumsScreen()
		{
			InitializeComponent();
			_timeSpanFormat = @"hh\:mm\:ss";
			_columnSorter = new ListViewColumnSorter();
			ListViewPossibleAlbums.ListViewItemSorter = _columnSorter;
			_columnSorter.Order = SortOrder.Descending;
			_columnSorter.SortColumn = ListViewPossibleAlbums.Columns.IndexOf(ColumnHeaderDuration);
		}

		private void ShowAllPossibleAlbumsScreen_Enter(object sender, EventArgs e)
		{
			ListViewPossibleAlbums.Items.Clear();
			_albums = BusinessFacade.Instance.GetPossibleAlbums();
			var minimumTime = BusinessFacade.Instance.GetMinimumAlbumTime();
			var maximumTime = BusinessFacade.Instance.GetMaximumAlbumTime();
			LabelAlbumTimeRange.Text=LabelAlbumTimeRange.Text.Replace("x", minimumTime.ToString(_timeSpanFormat)).Replace("y", maximumTime.ToString(_timeSpanFormat));
			foreach (var album in _albums)
			{
				var item = new ListViewItem(album.Artist) {ForeColor = album.Genre.Color};
				item.SubItems.Add(album.Title);
				item.SubItems.Add(album.Duration.ToString(_timeSpanFormat));
				item.SubItems.Add(album.AveragePlayCount.ToString("F5"));
				ListViewPossibleAlbums.Items.Add(item);
			}
			ListViewPossibleAlbums.Sort();
		}

		private AlbumDTO GetSelectedAlbum()
		{
			var selectedItem = ListViewPossibleAlbums.SelectedItems[0];
			return _albums.First(album =>
				album.Artist == selectedItem.Text && album.Title == selectedItem.SubItems[1].Text);
		}

		private void ListViewPossibleAlbums_DoubleClick(object sender, EventArgs e)
		{
			BusinessFacade.Instance.SetSelectedAlbum(GetSelectedAlbum());
			MoveToScreen(new AlbumTrackListScreen(),this);
		}

		private void ListViewPossibleAlbums_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			
			if (e.Column == _columnSorter.SortColumn)
			{
				_columnSorter.Order = _columnSorter.Order == SortOrder.Ascending
					? SortOrder.Descending
					: SortOrder.Ascending;
			}
			else
			{
				_columnSorter.SortColumn = e.Column;
				_columnSorter.Order = SortOrder.Ascending;
			}

			ListViewPossibleAlbums.Sort();
		}
	}
}
