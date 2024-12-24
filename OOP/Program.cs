using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static User user;
        static String login;
        static String password;
        static void Main(string[] args)
        {
            Console.WriteLine("\nРегистрация");
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            user = Utils.registerUser(login, password);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nАвторизация");
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                user = Utils.loginUser(login, password);
                Utils.loginUser("root", "12345");

                if (user == null)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин или пароль");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                }
                else { break; }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы успешно вошли!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"          Id: {user.Id}");
            Console.WriteLine($"    Username: {user.Username}");
            Console.WriteLine($"PasswordHash: {user.PasswordHash}");

            while (true) { }
        }
    }
}
