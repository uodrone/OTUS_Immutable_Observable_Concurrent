using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Library
    {
        ConcurrentDictionary<string, int> _library = new ConcurrentDictionary<string, int>();

        public Library() {
            
        }

        public bool Add(string name)
        {

            bool IsAdded = _library.TryAdd(name, 0);
            if (IsAdded) {
                Task.Run(async () => await BookReading(name));
            }
            return IsAdded;
        }

        private async Task BookReading(string name) {
            while (_library[name] < 100)
            {
                await Task.Delay(1000);
                _library[name]++;
                if (_library[name] == 100)
                {
                    if (_library.TryRemove(name, out int value))
                    {
                        Console.WriteLine($"Книга {name} полностью прочитана");
                    }
                }
            }
        }

        public void GetUnreadedBooks ()
        {
            if (_library.Count != 0)
            {
                foreach (var book in _library)
                {
                    Console.WriteLine($"Книга {book.Key} прочитана на {book.Value}%");
                }
            }
            else
            {
                Console.WriteLine("У вас нет непрочитанных книг, возьмите уже что-нибудь почитать!");
            }
        }
    }
}
