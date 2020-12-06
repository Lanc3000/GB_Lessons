using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
4. Реализовать метод проверки логина и пароля. 
    На вход подается логин и пароль. 
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

namespace L02HW04
{
    class Program
    {
        private static string login = "root";
        private static string password = "GeekBrains";
        static bool CheckLogin(string lg, string pasw) {
            if (lg == login && pasw == password)
                return true;
            return false;
        }
        static void LogOut() {
            Console.WriteLine("Программа проверки пользователя.");
            int count = 3;
            do
            {
                Console.WriteLine($"Введите логин и пароль. У вас {count} попытки.");
                Console.WriteLine("Ваш логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Ваш пароль:");
                string pasw = Console.ReadLine();

                if (CheckLogin(login, pasw))
                {
                    Console.WriteLine("Всё верно, вы авторизованны!");
                    break;
                }
                else
                {
                    count--;
                    Console.WriteLine($"Не правильный логин или пароль!");
                    Console.WriteLine("********************************");
                }
                    
            } while (count > 0);
            
        }
        static void Main(string[] args)
        {
            LogOut();
            Console.ReadKey();
        }
    }
}
