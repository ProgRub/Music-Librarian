using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.DTOs;
using Business.Enums;

namespace Forms
{
	public partial class SetAlbumPropertiesScreen : BaseControl
	{
		private bool _firstTime;

		private IEnumerable<GenreDTO> _genres;

		private IEnumerable<WorkoutDTO> _workouts;

		public SetAlbumPropertiesScreen()
		{
			InitializeComponent();
			_firstTime = true;
		}

		private void SetAlbumPropertiesScreen_Enter(object sender, EventArgs e)
		{
			_genres = BusinessFacade.Instance.GetAllGenres();
			_workouts = BusinessFacade.Instance.GetAllWorkouts();
			const int heightToAdd = 25;
			var height = CheckBoxSelectAll.Location.Y + heightToAdd;
			if (!_firstTime) return;
			_firstTime = false;
			foreach (var genre in _genres)
			{
				var checkBox = new CheckBox
				{
					ForeColor = genre.Color, Text = genre.Name,
					Location = new Point(CheckBoxSelectAll.Location.X, height), AutoSize = true, UseMnemonic = false
				};
				checkBox.Click += CheckBoxGenre_Clicked;
				tableLayoutPanelMain.RowCount+=1;
				tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, (float)((7 + _genres.Count()) / 100.0 * 100.0)));
				tableLayoutPanelMain.Controls.Add(checkBox,0, tableLayoutPanelMain.RowCount - 1);
				tableLayoutPanelMain.MinimumSize = new Size(tableLayoutPanelMain.MinimumSize.Width,
					tableLayoutPanelMain.MinimumSize.Height +30);
			}

			foreach (var workout in _workouts)
			{
				ComboBoxWorkouts.Items.Add($"{workout.Id} - {workout.Name}");
			}
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelMain,false);
			SetFormAcceptButton(ButtonGetPossibleAlbums);
		}

		private void ButtonGetPossibleAlbums_Click(object sender, EventArgs e)
		{
			BusinessFacade.Instance.SetAlbumProperties(DateTimePickerAlbumTime.Value.TimeOfDay,
				DateTimePickerLeeway.Value.TimeOfDay);
			BusinessFacade.Instance.SetSelectedGenres(_genres.Where(genre =>
				Controls.OfType<CheckBox>().Any(checkBox => checkBox.Checked && checkBox.Text == genre.Name)));
			BusinessFacade.Instance.SetLeewayType(GetSelectedLeewayType());
			MoveToScreen(new ShowAllPossibleAlbumsScreen(), this);
		}

		private LeewayType GetSelectedLeewayType()
		{
			return Controls.OfType<RadioButton>().First(e => e.Checked).Text switch
			{
				"Over" => LeewayType.Over,
				"Under" => LeewayType.Under,
				_ => LeewayType.OverAndUnder
			};
		}

		private void ButtonChooseWorkout_Click(object sender, EventArgs e)
		{
			BusinessFacade.Instance.SetSelectedWorkout(_workouts.First(e =>
				e.Id.ToString() == ComboBoxWorkouts.Text.Split(" - ")[0]));
			DateTimePickerAlbumTime.Value =
				DateTimePickerAlbumTime.MinDate.Add(BusinessFacade.Instance
					.GetAverageCompletionTimeOfSelectedWorkout());
			DateTimePickerLeeway.Value =
				DateTimePickerLeeway.MinDate.Add(BusinessFacade.Instance.GetMaximumLeewayOfSelectedWorkout());
		}

		private void ButtonAllAlbums_Click(object sender, EventArgs e)
		{
			DateTimePickerAlbumTime.Value = new DateTime(2000, 1, 1, 0,20, 0);
			DateTimePickerLeeway.Value = new DateTime(2000, 1, 1, 1, 30, 0);
			foreach (var checkBox in Controls.OfType<CheckBox>())
			{
				checkBox.Checked = true;
			}

			RadioButtonOver.Checked = true;
		}

		private void CheckBoxSelectAll_Click(object sender, EventArgs e)
		{
			foreach (var checkBox in Controls.OfType<CheckBox>().Where(checkBox => checkBox != CheckBoxSelectAll))
			{
				checkBox.Checked = CheckBoxSelectAll.Checked;
			}
		}

		private void CheckBoxGenre_Clicked(object sender, EventArgs e)
		{
			CheckBoxSelectAll.Checked = Controls.OfType<CheckBox>().Where(checkBox => checkBox != CheckBoxSelectAll)
				.All(checkBox => checkBox.Checked);
		}
	}
}