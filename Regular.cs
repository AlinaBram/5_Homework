using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Создать программу, которая будет проверять корректность ввода логина. Корректным логином 
//будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
//при этом цифра не может быть первой: б) **с использованием регулярных выражений.
namespace Regular
{
    static class CorrectLogin
    {
        public static void CorLog()
        {
            string username;
            Regex regex = new Regex(@"^[a-zA-Z][\w]{1,9}\b");

            do
            {
                Console.Clear();
                Console.WriteLine("Введите логин от 2 до 10 символов (но цифра не может быть первой):");
                username = Console.ReadLine();
                Console.Write(Check(username, regex) ? ($"\nЛогин корректный. Ваш логин: {Login(username, regex)}") : ($"\nЛогин некорректный"));
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static bool Check(string username, Regex regex)
        {
            return regex.IsMatch(username);
        }
        private static Match Login(string username, Regex regex)
        {
            return regex.Match(username);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CorrectLogin.CorLog();
        }
    }
}
