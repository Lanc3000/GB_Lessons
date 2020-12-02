using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Самигуллин Тимур
 4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 */

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу обмена значениями двух переменных");
            Console.WriteLine("*****************************************");

            int a = 10;
            int b = 5;
            Console.WriteLine($"До обмена a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"После обмена - a = {a}, b = {b}");

            a += b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Обратный обмен без третьей переменной - a = {a}, b = {b}");


            Console.ReadKey();
        }
    }
}
