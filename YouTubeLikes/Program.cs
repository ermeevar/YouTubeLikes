using System;

namespace YouTubeLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Авторизация");

            Console.Write("Придумайте логин: ");
            string login = Console.ReadLine();

            Console.Write("Придумайте пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine("Ваш логин и пароль сохранен!");

            while (true)
            {
                Console.WriteLine("Хотите ли вы войти в приложение? Да/Нет");
                string isEnter = Console.ReadLine();

                if (isEnter == "Да")
                {
                    Console.Write("Введите логин: ");
                    string newLogin = Console.ReadLine();

                    Console.Write("Введите пароль: ");
                    string newPassword = Console.ReadLine();

                    if (password == newPassword && login == newLogin)
                    {
                        Console.WriteLine("Ваш пароль и логин верен!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не правильный пароль");
                    }
                }
                else if (isEnter == "Нет")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Надо ответить Да или Нет");
                }
            }
        }
    }
}
