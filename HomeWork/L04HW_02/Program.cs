using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Тимур Самигуллин
    2. а) Дописать класс для работы с одномерным массивом. 
    Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
    Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
    умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
    В Main продемонстрировать работу класса.
    б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 */

namespace L04HW_02
{
    class MyArray
    {
        int[] a;
        private int sum  = 0;
        public int Sum { 
            get 
             {
                foreach (int el in a) {
                    sum += el;
                }
                return sum;
            }
        }
        public MyArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                var el = reader.ReadLine();
                int.TryParse(el, out int leng);
                a = new int[leng];
                for (int i = 0; i < leng; i++)
                {
                    if (int.TryParse(reader.ReadLine(), out int num))
                        a[i] = num;
                }

            }
            else throw new Exception("File is not exist");
            
        }
        public MyArray(int size, int start, int step)
        {
            a = new int[size];
            for (int i = 0; i < size; i++)
                {
                    a[i] = start;
                    start += step;
                } 
        }
        public void Inverse()
        {
            
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
            }
        }
        public void Multi(int num)
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i] *= num;
            }
        }
        public int Max()
        {
            int max = a[0];
            for(int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        public int MaxCount()
        {
            int count = 1;
            int max = a.Max();
            for (int i = 1; i < a.Length; i++) {
                if (a[i] == max)
                    count++;
            }
            return count;
        }
        public void Print()
        {
            foreach(int el in a)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10, -15, 3);
            array.Print();

            Console.WriteLine($"Перевернем получившийся массив используя метод Inverse");
            array.Inverse();
            array.Print();
            

            Console.WriteLine($"Сумма элементов массива равна = {array.Sum}");
            Console.WriteLine();


            var filePath = AppDomain.CurrentDomain.BaseDirectory + "Array.txt";
            MyArray arrFromFile = new MyArray(filePath);
            Console.WriteLine($"Массив созданный из файла:");
            arrFromFile.Print();

            Console.WriteLine($"Количество максимальных элементов в arrFromFile:");
            Console.WriteLine($"Максимальный элемент {arrFromFile.Max()} повторяется {arrFromFile.MaxCount()} раз");
            Console.WriteLine();

            arrFromFile.Multi(3);
            Console.WriteLine($"Метод Multi увеличил каждый элемент массива на 3");
            arrFromFile.Print();

            Console.ReadKey();
        }
    }
}
