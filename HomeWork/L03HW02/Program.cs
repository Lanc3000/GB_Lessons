using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    Требуется подсчитать сумму всех нечетных положительных чисел. 
    Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 */

namespace L03HW02
{
    class Program
    {

        public static int sum = 0;
        public static int num = 0;
        static void Sum()
        {
            string s = Console.ReadLine();
            if (!s.Equals("0"))
            {
                
                    if (int.TryParse(s, out num))
                    { //Сами числа и сумму вывести на экран, используя tryParse - вот тут не совсем понял задание
                        if (num % 2 != 0 && num > 0) //зачем tryParse для суммы?
                            sum += num;
                    }
                    else
                        throw new Exception("Допустимы только числа");
                
                Sum();
            }
            else
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"Сумма нечетных положительных чисел равна: {sum}");
                Console.WriteLine("************************************");
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа. Для окончания ввода, введите \"0\"");
            Sum();
            Console.ReadKey();
        }
    }
}
