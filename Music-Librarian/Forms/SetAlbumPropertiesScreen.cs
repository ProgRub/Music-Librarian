using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public partial class SetAlbumPropertiesScreen : BaseControl
	{
		public SetAlbumPropertiesScreen()
		{
			InitializeComponent();
		}

		private void ButtonGetPossibleAlbums_Click(object sender, EventArgs e)
		{
			MoveToScreen(new ShowAllPossibleAlbumsScreen(),this);
		}

		private void ButtonChooseWorkout_Click(object sender, EventArgs e)
		{
			if (ButtonChooseWorkout.Text == "Choose Workout")
			{
				ButtonChooseWorkout.Text = "Get Album Time For Selected Workout";
				ComboBoxWorkouts.Enabled = true;
			}
			else
			{
				ButtonChooseWorkout.Text = "Choose Workout";
				ComboBoxWorkouts.Enabled = false;
			}
		}
	}
}
