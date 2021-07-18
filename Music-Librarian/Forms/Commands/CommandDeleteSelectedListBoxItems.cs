using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business.Commands;

namespace Forms.Commands
{
	public class CommandDeleteSelectedListBoxItems : ICommand
	{
		private readonly ListBox _listBox;
		private readonly IList<object> _items;
		private readonly IList<int> _itemIndices;

		public CommandDeleteSelectedListBoxItems(ListBox listBox)
		{
			_listBox = listBox;
			_itemIndices = new List<int>();
			foreach (int selectedIndex in _listBox.SelectedIndices)
			{
				_itemIndices.Add(selectedIndex);
			}
			_items = new List<object>();
			foreach (var itemIndex in _itemIndices)
			{
				_items.Add(_listBox.Items[itemIndex]);
			}
		}

		public void Execute()
		{
			for (var index = 0; index < _items.Count; index++)
			{
				_listBox.Items.Remove(_items.ElementAt(index));
			}
		}

		public void Undo()
		{
			for (var index = 0; index < _itemIndices.Count; index++)
			{
				_listBox.Items.Insert(_itemIndices[index], _items[index]);
			}
		}

		public void Redo()
		{
			Execute();
		}
	}
}