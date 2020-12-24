using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    Продемонстрируйте работу программы на текстовом файле с вашей программой.
 */
namespace L05HW_02
{
    class Message{
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        static void PrintNWords(string mes, int num) {
            var words = mes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length <= num)
                    Console.WriteLine(words[i]);
            }
        }
        static void Deletewords(string mes)
        {

        }
        static string LongestWord(string mes)
        {
            return "";
        }
        static void LongestsWords(string mes)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string _filePath = AppDomain.CurrentDomain.BaseDirectory + "SomeText";
            StreamReader reader = new StreamReader(_filePath);
            string word = "";
            do
            {
                word = reader.ReadLine();

            } while (word.Equals(""));
        }
    }
}
