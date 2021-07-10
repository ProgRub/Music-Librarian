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
	public partial class ShowAllPossibleAlbumsScreen : BaseControl
	{
		public ShowAllPossibleAlbumsScreen()
		{
			InitializeComponent();
		}

		private void ButtonShowSelectedAlbumTracklist_Click(object sender, EventArgs e)
		{
			MoveToScreen(new AlbumTracklistScreen(),this);
		}
	}
}
