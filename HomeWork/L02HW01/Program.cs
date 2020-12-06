using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02HW01
{
    /*
     Тимур Самигуллин
    1. Написать метод, возвращающий минимальное из трех чисел.
     */
    class Program
    {
        static int Min(int a, int b, int c) {
            int min;
            if (a < b && a < c)
                min = a;
            else if (b < a && b < c)
                min = b;
            else
                min = c; 
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Метод возвращающий минимальное из трёх числел");
            Console.WriteLine($"минимальное из -5, 3, 3 = {Min(-5, 3, 3)}");
            Console.ReadKey();
        }
    }
}
