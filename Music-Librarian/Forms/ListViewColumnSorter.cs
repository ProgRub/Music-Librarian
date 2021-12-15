using System.Collections;
using System.Windows.Forms;

namespace Forms
{
	public class ListViewColumnSorter : IComparer
	{
		private int _columnToSort;
		private SortOrder _orderOfSort;
		private readonly CaseInsensitiveComparer _objectCompare;
		internal int SortColumn
		{
			set => _columnToSort = value;
			get => _columnToSort;
		}
		internal SortOrder Order
		{
			set => _orderOfSort = value;
			get => _orderOfSort;
		}
		public ListViewColumnSorter()
		{
			_columnToSort = 0;
			_orderOfSort = SortOrder.None;
			_objectCompare = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
			var listViewX = (ListViewItem) x;
			var listViewY = (ListViewItem) y;
			
			int compareResult;
            if (float.TryParse(listViewX.SubItems[_columnToSort].Text, out var a) &&
                float.TryParse(listViewY.SubItems[_columnToSort].Text, out var b))
            {
                if (a < b) compareResult = -1;
				else if (a > b) compareResult = 1;
				else compareResult=0;


            }else{
                compareResult = _objectCompare.Compare(listViewX.SubItems[_columnToSort].Text,
                    listViewY.SubItems[_columnToSort].Text);
            }
            

            return _orderOfSort switch
			{
				SortOrder.Ascending => compareResult,
				SortOrder.Descending => (-compareResult),
				_ => 0
			};
		}
	}
}