using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
        нужно ли человеку похудеть, набрать вес или все в норме;
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

namespace L02HW05
{  
    class Program
    {
        static double CalculateMassIndex(float w, float h) => w / (Math.Pow(h, 2)); //возвразает индекс массы тела

        static void CorrectingMass(double index, float height) //возвращает величину корректировки до нормальной массы тела
        {
            double corr;
            if (index <= 18.5)
            {
                corr = (18.5 - index) * Math.Pow(height, 2);
                Console.WriteLine("Необходимо набрать {0:f2} кг.", corr);
            }
            else if (index > 25) {
                corr = (index - 25) * Math.Pow(height, 2);
                Console.WriteLine("Необходимо сбросить {0:f2} кг.", corr);
            }
        }

        static void HealthMessanger(double index, float height)
        {
            if (index <= 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела! Срочно в Макдональдс!!!");
            }
            else if (index > 16 && index <= 18.5)
            {
                Console.WriteLine("	Недостаточная (дефицит) масса тела. Рекомендуется усиленное питание.");
            }
            else if (index > 18.5 && index <= 25)
            {
                Console.WriteLine("Норма. Всё хорошо, продолжайте в том же духе!");
            }
            else if (index > 25 && index <= 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение). Можно немного ограничивать себя в калориях.");
            }
            else if (index > 30 && index <= 35)
            {
                Console.WriteLine("Ожирение. Пора на беговую дорожку и сбалансированное питание!");
            }
            else if (index > 35 && index <= 40)
            {
                Console.WriteLine("Резкое ожирение. Срочно на диету!");
            }
            else
                Console.WriteLine("Очень резкое ожирение. Вам нужен диетолог!");
            CorrectingMass(index, height);
        }
        static void WeightAssistant() {
            Console.WriteLine("Добро пожаловать в приложение вычисления ИМТ ");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Введите ваш вес в кг:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах (например \"1,7\"):");
            float height = float.Parse(Console.ReadLine());

            double index = CalculateMassIndex(weight, height);
            Console.WriteLine();

            Console.Write("Ваш индекс массы тела составляет: ");
            Console.WriteLine("{0:f2}", index);
            Console.WriteLine();
            HealthMessanger(index, height);

            Console.WriteLine("Для выхода нажмите любую клавишу");
            
        }
        static void Main(string[] args)
        {
            WeightAssistant();
            Console.ReadKey();
        }
    }
}
