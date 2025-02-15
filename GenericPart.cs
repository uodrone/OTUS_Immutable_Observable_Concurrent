using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal abstract class GenericPart<T> : IPart where T : GenericPart<T>, new()
    {
        public ImmutableList<string> Poem { get; protected set; } = ImmutableList<string>.Empty;

        public virtual ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            return Poem = AddLines(previousPoem);
        }

        // Метод для добавления строк в коллекцию
        protected abstract ImmutableList<string> AddLines(ImmutableList<string> previousPoem);

        // Реализация метода вывода
        public void PrintPoem(string partName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(partName);
            Console.ResetColor();

            foreach (var line in Poem)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }
    }


}
