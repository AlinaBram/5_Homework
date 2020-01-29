using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
namespace _5_Homework3
{
    class Program
    {
        static class Check
        {
            public static void CheckMethod()
            {
                StringBuilder str1, str2;
                string no_permutation = "\nСтрока2 не является перестановкой букв Строки1";
                string permutation = "\nСтрока2 является перестановкой букв Строки 1";

                do
                {
                    Console.Clear();

                    Console.Write("Введите 1 строку: ");
                    str1 = new StringBuilder(Console.ReadLine());

                    Console.Write("\nВведите 2 строку: ");
                    str2 = new StringBuilder(Console.ReadLine());

                    if (str1.Length != str2.Length)
                    {
                        Console.WriteLine(no_permutation);
                        continue;
                    }

                    Sort(ref str1);
                    Sort(ref str2);

                    Console.WriteLine(str1);
                    Console.WriteLine(str2);

                    Console.WriteLine(str1.Equals(str2) ? permutation : no_permutation);

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            }
            private static void Sort(ref StringBuilder str)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = 0; j < str.Length - 1 - i; j++)
                    {
                        if (str[j] > str[j + 1])
                        {
                            char[] temp = { str[j] };
                            str[j] = str[j + 1];
                            str[j + 1] = temp[0];
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Check.CheckMethod();
        }
    }
}
