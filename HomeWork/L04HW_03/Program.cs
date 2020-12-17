using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Тимур Самигуллин
    3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
        Создайте структуру Account, содержащую Login и Password.
 */

namespace L04HW_03
{
    struct Account{
        private static string login;
        private static string password;
        public string Login { 
            get {
                return login;
            }
        }
        public string Password {
            get
            {
                return password;
            }
        }
        public void InitializeFromFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "AccInfo.txt";
            StreamReader reader = new StreamReader(filePath);
            login = reader.ReadLine();
            password = reader.ReadLine();
        }  
    }
    class Program
    {   
        static bool CheckLogin(string lg, string pasw)
        {
            Account acc;
            acc.InitializeFromFile();
            if (lg == acc.Login && pasw == acc.Password)
                return true;
            return false;
        }
        static void LogOut()
        {
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

