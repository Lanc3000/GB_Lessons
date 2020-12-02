using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Самигуллин Тимур

1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.

 */

namespace HW01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение \"Анкета\" ");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Введите ваше имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Ввелите ваш возраст:");
            byte age = byte.Parse(Console.ReadLine()); //запрашиваем возраст и приводим строку к целочисленному значению 
                                                       //byte - т.к. вряд ли есть люде старше 255 лет
            Console.WriteLine("Введите ваш рост:");
            ushort height = ushort.Parse(Console.ReadLine()); /*byte маловато, а int слишком большой запас.
                                                              тип с плавающей запятой не стал использовать, предполагая что рост до мм обычно не сообщают,
                                                              а вот вес можно было запихнуть в переменную float или double
                                                               */
            Console.WriteLine("Введите ваш вес:");
            ushort weight = ushort.Parse(Console.ReadLine());

            Console.WriteLine("Конкатенация: \n" 
                                                + "Имя - " + firstName 
                                                + " Фамилия - " + lastName 
                                                + " возраст - " + age
                                                + " рост - " + height
                                                + " вес - " + weight);
            Console.WriteLine("**********************************************");

            Console.WriteLine("Форматированный вывод: \n имя - {0} фамилия - {1} возраст - {2} рост - {3} вес - {4}", 
                                                            firstName, lastName, age, height, weight);
            Console.WriteLine("**********************************************");

            Console.WriteLine($"Вывод используя $: \n имя: {firstName} фамилия: {lastName} возраст: {age} рост: {height} вес: {weight}");

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
