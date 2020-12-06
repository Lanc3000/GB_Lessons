using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
 6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    Хорошим называется число, которое делится на сумму своих цифр. 
    Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

namespace L02HW06
{
    class Program
    {
        static int Sum(int a)                    
        {
            int s = 0;
            while (a > 0)                  
            {
                s = s + a % 10;          
                a = a / 10;              
            }
            return s;                    
        }
        static int GoodNumbers()
        {
            int count = 0;
            int range = 1_000_000_000;
            for (int i = 1; i < range; i++) {
                if (i % Sum(i) == 0)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Считаем, ожидаемое время ~ 2 мин");
            DateTime start = DateTime.Now;

            Console.WriteLine(GoodNumbers());

            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start); 

            Console.ReadKey();
        }
    }
}
