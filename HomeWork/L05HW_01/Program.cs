using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
 Тимур Самигуллин
 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) с использованием регулярных выражений.
 */
namespace L05HW_01
{
    class Program
    {
        static bool IsCorrectLogWithRegEx(string log)
        {
            Regex myReg = new Regex(@"[A-Za-z]{1}[A-Za-z0-9]{2,10}"); // не знаю как вывести что конкретно не верно в "логине", если не разделять 
            if (myReg.IsMatch(log)) // регулярку на два метода (наподобие методов для задачи "а")
                return true;
            else
                return false;
        }
        
        static bool IsCorrectLog(string log)
        {
            char[] checkArr = log.ToCharArray();

            if (IsCorrectLength(checkArr) && IsNotNumber(checkArr[0]) && IsLatinLetters(checkArr))
                return true;
            else
                return false;
        }
        static bool IsCorrectLength(char[] array)
        {
            bool check = false;
            if (array.Length >= 2 && array.Length <= 10)
                check = true;
            if(!check)
                Console.WriteLine("Некорректная длина");
            return check;
        }
        static bool IsLatinLetters(char[] array)
        {
            bool res = true;
            for(int i = 1; i < array.Length; i++)
            {
                if (!Char.IsDigit(array[i]) && !(((array[i] >= 'a') && (array[i] <= 'z')) || ((array[i] >= 'A') && (array[i] <= 'Z'))))
                {
                    res = false;
                    Console.WriteLine("Не латинский алфавит или не числа");
                    break;
                }
            }
            return res;
        }
        static bool IsNotNumber(char first)
        {
            if (Char.IsNumber(first))
            {
                Console.WriteLine("Первый символ не может быть числом");
                return false;
            }
            else
                return true;
        }
        static void LogOn(string log)
        {
            if(IsCorrectLog(log))
                Console.WriteLine("Корректный логин");
        }

        static void LogOnForReg(string log)
        {
            if (IsCorrectLogWithRegEx(log))
                Console.WriteLine("Корректный логин");
            else
                Console.WriteLine("Что-то не так");
        }
        static void Main(string[] args)
        {
            string log1 = "2fgioj";
            string log2 = "g";
            string log3 = "логин";
            string log4 = "corLog1";
            Console.WriteLine($"проверяем логин \"{log1}\": ");
            LogOn(log1);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин \"{log2}\": ");
            LogOn(log2);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин \"{log3}\": ");
            LogOn(log3);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин \"{log4}\": ");
            LogOn(log4);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин при помощи Regex \"{log1}\": ");
            LogOnForReg(log1);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин при помощи Regex \"{log2}\": ");
            LogOnForReg(log2);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин при помощи Regex \"{log3}\": ");
            LogOnForReg(log3);
            Console.WriteLine("");

            Console.WriteLine($"проверяем логин при помощи Regex \"{log4}\": ");
            LogOnForReg(log4);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
