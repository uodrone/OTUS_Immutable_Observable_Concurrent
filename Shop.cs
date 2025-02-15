using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Shop
    {
        public ObservableCollection<Item> items = new ObservableCollection<Item>();
        int ItemId = 0;

        public void Add(string Name)
        {
            items.Add(new Item(ItemId, Name));
            ItemId++;
        }

        public bool Remove(int Id)
        {
            bool IsElementRemove = false;

            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].Id == Id)
                {
                    items.RemoveAt(i);
                    IsElementRemove = true;
                }
            }

            return IsElementRemove;
        }
    }
}
