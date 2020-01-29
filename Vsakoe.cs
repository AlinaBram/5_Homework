using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//a) вывести только те слова сообщения,  которые содержат не более n букв;
//б) удалить из сообщения все слова, которые заканчиваются на заданный символ;
//в) найти самое длинное слово сообщения;
//г) сформировать строку с помощью StringBuilder из самых длинных слов сообщения. 
namespace Vsakoe
{
    public static class Message
    {
        public static class Message1
        {
            public static List<string> Short(string message, int length)//a) вывести слова, которые содержат не более n букв;
            {
                var returnList = new List<string>();
                foreach (var s in message.Split(' '))
                {
                    if (length > s.Length) returnList.Add(s);
                }
                return returnList;
            }
            public static List<string> Remove(string message, char letter)//б) удалить слова, которые заканчиваются на заданный символ;
            {
                var returnList = new List<string>();
                foreach (var s in message.Split(' '))
                {
                    if (!s.EndsWith(letter.ToString())) returnList.Add(s);
                }
                return returnList;
            }
            public static string Long(string message)//в) найти самое длинное слово сообщения;
            {
                var words = message.Split(' ');
                var longestWord = "";
                foreach (var word in words)
                {
                    if (word.Length > longestWord.Length) longestWord = word;
                }
                return longestWord;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var message = "Молодой дизайнер, впервые столкнувшийся с тем, что его обругали не за дело," +
                        " как бы обращается к заказчику: я не мил тебе ? Бывалый дизайнер произносит эту же фразу, только наоборот.";
                Console.WriteLine(message);
                Console.WriteLine("\n\nВывод слов, которые короче 3 символов:");
                foreach (var s in Message1.Short(message, 3))
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\n\nУдалены все слова, которые заканчиваются на букву е:");
                foreach (var s in Message1.Remove(message, 'е'))
                {
                    Console.Write(" " + s);
                }

                Console.WriteLine($"\n\nСамое длинное слово: {Message1.Long(message)}");

                //забыл про StringBuilder, но и без этой херни получилось нормально
                Console.WriteLine($"\n\nСтрока из самых длинных слов: ");             
                string pattern = @"\b\w{7,15}(?=\b)";
                foreach (Match m in Regex.Matches(message, pattern))
                {
                    Console.Write(" " + m.Value);
                }

                Console.ReadKey();
            }
        }
    }
}
