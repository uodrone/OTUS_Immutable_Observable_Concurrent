namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Shop = new Shop();
            var Customer = new Customer();

            Shop.items.CollectionChanged += Customer.OnItemChanged;

            Console.WriteLine("Нажмите A, чтобы добавить товар.");
            Console.WriteLine("Нажмите D, чтобы удалить товар.");
            Console.WriteLine("Нажмите X, чтобы выйти.");

            while (true)
            {
                // Ожидаем нажатия клавиши
                var key = Console.ReadKey(intercept: true).Key;

                switch (key)
                {
                    case ConsoleKey.A:
                        string itemName = $"Товар от {DateTime.Now}";
                        Shop.Add(itemName);
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Введите id товара для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            if (!Shop.Remove(id))
                            {
                                Console.WriteLine("Элемента с таким id не существует");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный идентификатор.");
                        }
                        break;

                    case ConsoleKey.X:
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}
