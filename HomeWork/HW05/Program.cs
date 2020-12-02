using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */

namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {

            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            Console.SetCursorPosition(centerX, centerY);

            string firstName = "Тимур";
            string lastName = "Самигуллин";
            string city = "Москва";

            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName}, город проживания: {city} ");

            Console.SetCursorPosition(centerX, centerY + 1);
            PrintText(firstName, lastName, city);
            Console.ReadKey();
        }

        static void PrintText(string name, string fam, string city)
        {
            Console.WriteLine($"Имя: {name} Фамилия: {fam}, город проживания: {city}");
        }
    }
}
