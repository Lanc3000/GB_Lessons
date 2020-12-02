using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Самигуллин Тимур
 2. Ввести вес и рост человека. 
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах
 */

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение вычисления ИМТ ");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Введите ваш вес в кг:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах (например \"1,7\"):");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Ваш индекс массы тела составляет: ");
            Console.WriteLine("{0:f2}",CalculateMassIndex(weight, height));

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }

        static double CalculateMassIndex(float w, float h) {
            return w / (Math.Pow(h, 2));
        }
    }
}
