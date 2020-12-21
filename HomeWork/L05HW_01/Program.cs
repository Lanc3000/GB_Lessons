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
        private static char[] _login = { 'a', 'b', 'c', 'd', 'i', 'f' ,'j','k','l','m','n','p','q','r','s','t','u','v','w','x','y','z', '0','1','2','3','4','5','6','7','8','9'};
        public static char[] Login { get { return _login; } }
        static bool IsCorrectLog(string log)
        {
            bool check = false;
            char[] checkArr = log.ToCharArray();
            for(int i = 0; i < checkArr.Length; i++)
            {
                for (int j = 0; j < Login.Length; j++) { 
                    
                }
            }
            return check;
        }
        static void LogOn()
        {
            Console.WriteLine("Ведите логин:");
            string log = Console.ReadLine();
        }
        static void Main(string[] args)
        {

        }
    }
}
