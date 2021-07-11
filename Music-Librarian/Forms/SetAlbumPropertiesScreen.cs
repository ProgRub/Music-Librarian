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
using Business.DTOs;
using Business.Enums;

namespace Forms
{
	public partial class SetAlbumPropertiesScreen : BaseControl
	{

		private IEnumerable<GenreDTO> _genres;
		public SetAlbumPropertiesScreen()
		{
			InitializeComponent();
		}

		private void ButtonGetPossibleAlbums_Click(object sender, EventArgs e)
		{
			BusinessFacade.Instance.SetAlbumProperties(DateTimePickerAlbumTime.Value.TimeOfDay,
				DateTimePickerLeeway.Value.TimeOfDay);
			BusinessFacade.Instance.SetSelectedGenres(_genres.Where(genre =>
				Controls.OfType<CheckBox>().Any(checkBox =>checkBox.Checked&& checkBox.Text == genre.Name)));
			BusinessFacade.Instance.SetLeewayType(GetSelectedLeewayType());
			MoveToScreen(new ShowAllPossibleAlbumsScreen(),this);
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
			if (ButtonChooseSelectWorkout.Text == "Choose Workout")
			{
				ButtonChooseSelectWorkout.Text = "Get Album Time For Selected Workout";
				ComboBoxWorkouts.Enabled = true;
			}
			else
			{
				ButtonChooseSelectWorkout.Text = "Choose Workout";
				ComboBoxWorkouts.Enabled = false;
			}
		}

		private void ButtonAllAlbums_Click(object sender, EventArgs e)
		{
			DateTimePickerAlbumTime.Value = new DateTime(2000, 1,1, 1, 30, 0);
			DateTimePickerLeeway.Value = new DateTime(2000, 1,1, 1, 30, 0);
		}

		private void SetAlbumPropertiesScreen_Enter(object sender, EventArgs e)
		{
			_genres = BusinessFacade.Instance.GetAllGenres();
			var heightToAdd = 25;
			var height = CheckBoxSelectAll.Location.Y + heightToAdd;
			foreach (var genre in _genres)
			{
				var checkBox = new CheckBox
				{
					ForeColor = genre.Color, Text = genre.Name,
					Location = new Point(CheckBoxSelectAll.Location.X, height),AutoSize = true,UseMnemonic = false
				};
				checkBox.Click += CheckBoxGenre_Clicked;
				Controls.Add(checkBox);
				height += heightToAdd;
			}
		}

		private void CheckBoxSelectAll_Click(object sender, EventArgs e)
		{
			foreach (var checkBox in Controls.OfType<CheckBox>().Where(checkBox=>checkBox!=CheckBoxSelectAll))
			{
				checkBox.Checked = CheckBoxSelectAll.Checked;
			}
		}

		private void CheckBoxGenre_Clicked(object sender, EventArgs e)
		{
			CheckBoxSelectAll.Checked = Controls.OfType<CheckBox>().Where(checkBox=>checkBox!=CheckBoxSelectAll).All(checkBox => checkBox.Checked);
		}
	}
}
