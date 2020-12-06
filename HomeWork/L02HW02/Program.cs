using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
2. Написать метод подсчета количества цифр числа
 */

namespace L02HW02
{
    class Program
    {
        public static int count = 0;
        static int Sum(int a)
        {
            a = Math.Abs(a); //для отрицательных чисел
            if (a == 0)
                return 1;
            else if (a > 0)
            {
                count++;
                a = a / 10;
                Sum(a);
            }
          return count;
        }
        static int Sum(double a) { //не сообразил как без перевода в строку посчитать количество цифр после запятой(
            string number = a.ToString();
            string result = "";
            foreach (char el in number) {
                if (el != '.' && el != ',') {
                    result += el;
                }
            }
            return result.Length;
        }
        static void Main(string[] args)
        {
            int a = -4450;
            double b = 100.34;
            Console.WriteLine($" количество цифр в числе {a} : {Sum(a)}");
            Console.WriteLine($" количество цифр в числе {b} : {Sum(b)}");
            Console.ReadKey();
        }
    }
}
