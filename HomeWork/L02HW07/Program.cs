using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин

7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

namespace L02HW07
{

    class Program
    {
        static void OutputRange(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) 
                OutputRange(++a, b);    
        }
        static int SumOfRange(int a, int b) {
            if (a <= b)
                return SumOfRange(++a, b) + a;
            return 0;
        }
        static int SumNumber(int a, int b)
        {
            if (a <= b)
            {
                var sum = SumNumber(a + 1, b);
                return a + sum;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            OutputRange(3, 10);
            Console.WriteLine(SumOfRange(5, 7));
            Console.WriteLine(SumNumber(5, 7));
            Console.ReadKey();
        }
    }
}
