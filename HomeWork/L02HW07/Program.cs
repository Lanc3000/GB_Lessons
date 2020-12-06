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
            if (a == b)
                return a;
            else
                return SumOfRange(++a, b) + a;
           
        }
        static void Main(string[] args)
        {
            OutputRange(3, 10);
            Console.WriteLine(SumOfRange(5, 10));
            Console.ReadKey();
        }
    }
}
