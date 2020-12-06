using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
3. С клавиатуры вводятся числа, пока не будет введен 0. 
    Подсчитать сумму всех нечетных положительных чисел.
 */
namespace L02HW03
{
    class Program
    {
        static bool IsNotOdd(int a)
        {
            if (a % 2 != 0)
                return true;
            return false;
        }
        static void Sum() {
            Console.WriteLine("Введите необходимое количество чисел. \n Для окончания ввода, введите \"0\".");
            string s = "";
            int temp;
            int sum = 0;
            do
            {
                s = Console.ReadLine();
                temp = int.Parse(s);

                if (IsNotOdd(temp) && temp > 0)
                    sum += temp;

            } while (s != "0");

            Console.WriteLine($"Сумма всех нечетных положительных чисел составляет: {sum}");
        }
        static void Main(string[] args)
        {
            Sum();
            Console.ReadKey();

        }
    }
}
