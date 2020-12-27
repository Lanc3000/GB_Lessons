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
        
        public static void PrintNWords(string mes, int num) {
            var words = mes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length <= num)
                    Console.Write($"{words[i]} ");
            }
        }
        public Message(string mes)
        {
            //PrintNWords(mes, 4);
            //Deletewords(mes, 'r');
            SumLongestWords(mes); //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

        }
        static void Deletewords(string mes, char del)//Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            var words = mes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1].Equals(del))
                {
                    words[i] = "";
                }
                    Console.Write($"{words[i]} ");
            }
        }
        static string LongestWord(string mes) //Найти самое длинное слово сообщения.
        {
            var words = mes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string max = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > max.Length)
                    max = words[i];
            }
            return max;
        }
        static void SumLongestWords(string mes) //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        {
            var words = mes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int lng = words.Length / 2; // установим максимальную длину StringBuilder в половину пердаваемого сообщения
            StringBuilder longestWords = new StringBuilder(lng);
            
            int maxLength = LongestWord(mes).Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length == maxLength)
                    longestWords.Append(words[i] + " ");        
            }
            Console.WriteLine(longestWords);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string _filePath = AppDomain.CurrentDomain.BaseDirectory + "SomeText.txt";
            string word;

            using (StreamReader reader = new StreamReader(_filePath))
            {
                word = reader.ReadToEnd(); 
            }

            Message myMes = new Message(word);
            
            Console.ReadKey();
        }
    }
}
