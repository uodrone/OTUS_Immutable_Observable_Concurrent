using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            var col = sender as ObservableCollection<Item>;

            switch (e.Action) { 
                case NotifyCollectionChangedAction.Add:
                    // e.NewItems содержит список добавленных элементов
                    foreach (Item newItem in e.NewItems)
                    {
                        Console.WriteLine($"Добавлен товар: {newItem.Name}");
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    //e.OldItems содержит список удолённых элементов
                    foreach (Item oldItem in e.OldItems)
                    {
                        Console.WriteLine($"Элемент удалён: {oldItem.Name}");
                    }
                    break;
            }
        }
    }
}
