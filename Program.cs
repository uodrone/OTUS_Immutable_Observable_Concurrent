using System.Collections.Immutable;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImmutableList<string> poem = ImmutableList<string>.Empty;

            // Создаем экземпляры всех частей
            var parts = new IPart[]
            {
                new Part1(),
                new Part2(),
                new Part3(),
                new Part4(),
                new Part5(),
                new Part6(),
                new Part7(),
                new Part8(),
                new Part9()
            };

            // Последовательно вызываем методы AddPart
            foreach (var part in parts)
            {
                poem = part.AddPart(poem);
            }

            // Выводим результат каждой части
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].PrintPoem($"Часть стишка {i + 1}");
            }
        }
    }
}
