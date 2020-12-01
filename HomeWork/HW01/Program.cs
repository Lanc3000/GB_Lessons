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
            int age = int.Parse(Console.ReadLine()); //запрашиваем возраст и приводим строку к целочисленному значению

            Console.WriteLine("Введите ваш рост:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес:");
            int weight = int.Parse(Console.ReadLine());

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
            Console.ReadKey();
        }
    }
}
