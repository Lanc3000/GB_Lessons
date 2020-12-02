using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Самигуллин Тимур
3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу вычисления расстояния м/у точками");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Введите x1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2:");
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками составляет: {0:f2}", lenght);

            Console.WriteLine("Используя метод: {0:f2}", CalculateLengthOfPoints(x1, y1, x2, y2));

            Console.ReadKey();
        }

        static double CalculateLengthOfPoints(double x1, double y1, double x2, double y2) {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
