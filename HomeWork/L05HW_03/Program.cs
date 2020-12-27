using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
    3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. 
            Регистр можно не учитывать:
        а) с использованием методов C#;
        б) *разработав собственный алгоритм.
    Например:
        badc являются перестановкой abcd.
 */
namespace L05HW_03
{
    class Program
    {
        public static bool PermutationA(string a, string b) {
            bool answer = false;
            a = a.ToLower();
            b = b.ToLower();

            if (a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x)))
                answer = true;
           
                return answer;
        }
        public static char[] SortChar(string a) {
            char[] array = a.ToCharArray();
            char temp;
            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static bool PermutationB(string a, string b)
        {
            bool answer = false;
            char[] arr1 = SortChar(a.ToLower());
            char[] arr2 = SortChar(b.ToLower());
            if (arr1.Length != arr2.Length)
            {
                return answer;
            }
            else {
                for (int i = 0; i < arr1.Length; i++) {
                    if (arr1[i] != arr2[i]) {
                        return false;
                    }
                    answer = true;
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            string s1 = "bacd";
            string s2 = "abcD";
            Console.WriteLine($"Сравним {s1} и {s2}: {PermutationA(s1,s2)}");

            Console.WriteLine($"Сравним {s1} и {s2}: {PermutationB(s1, s2)}");
            Console.ReadKey();
        }
    }
}
