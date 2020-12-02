using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Тимур Самигуллин
6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

 */

namespace HW06
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.Pause(2000);
            my.Print("test");
            Console.ReadKey();

        }
    }
    public class MyClass {
        public void Print(string mess) {
            Console.WriteLine(mess);
        }
        public void Pause(int time) {
            System.Threading.Thread.Sleep(time);
        }
    }

}
