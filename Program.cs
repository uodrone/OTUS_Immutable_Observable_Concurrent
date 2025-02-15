namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Library = new Library();

            ShowMenu();

            while (true)
            {
                // Ожидаем нажатия клавиши
                var key = Console.ReadKey(intercept: true).Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        while (true)
                        {
                            Console.WriteLine("Введите название книги");
                            string input = Console.ReadLine();

                            
                            if (!string.IsNullOrEmpty(input))
                            {
                                Library.Add(input);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Название книги не может быть пустым. Попробуйте снова.");
                            }
                        }
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Непрочитанные книги:");
                        Library.GetUnreadedBooks();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВозвращаемся в меню:");
                Console.ResetColor();
                ShowMenu();                
            }
        }

        static void ShowMenu ()
        {
            Console.WriteLine("Нажмите 1, чтобы добавить книгу.");
            Console.WriteLine("Нажмите 2, чтобы вывести список непрочитанного.");
            Console.WriteLine("Нажмите 3, чтобы выйти.");
        }
    }
}
