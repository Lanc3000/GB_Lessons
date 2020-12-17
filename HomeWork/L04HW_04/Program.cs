using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Тимур Самигуллин
    4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
        Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
            возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, 
            метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    Дополнительные задачи
    в) Обработать возможные исключительные ситуации при работе с файлами.
 */

namespace L04HW_04
{
    class MyBinarArray
    {
        int[,] a;
        public MyBinarArray(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }
        public MyBinarArray(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);

                int.TryParse(reader.ReadLine(), out int row);
                int.TryParse(reader.ReadLine(), out int column);
                a = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (int.TryParse(reader.ReadLine(), out int num))
                            a[i, j] = num;
                        else
                            throw new InvalidCastException("not number");
                    }
                }
            }
            else
                throw new FileNotFoundException("File not found");
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }
        public int SumAllElements()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++){

                for (int j = 0; j < a.GetLength(1); j++){

                    sum += a[i, j];
                }
            }
                return sum;
        }
        public int SumAllElemWithParam(int num)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++){

                for (int j = 0; j < a.GetLength(1); j++){
                    if(a[i,j] > num)
                        sum += a[i, j];
                }
            }
            return sum;
        }
        public void IndexOfMax(out int row, out int colon)
        {
            int max = Max;
            row = 0;
            colon = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max == a[i, j]){ // номер максимального элемента массива
                        row = i;
                        colon = j;
                    }
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; 
            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyBinarArray a = new MyBinarArray(4, 0, 10);
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Максимальный элемент: {a.Max}");
            Console.WriteLine($"Минимальный элемент: {a.Min}");
            Console.WriteLine($"Сумма всех элементов: {a.SumAllElements()}");
            int num = 4;
            Console.WriteLine($"Сумма всех элементов больше {num}: {a.SumAllElemWithParam(num)}");
            int row;
            int colon;
            a.IndexOfMax(out row, out colon);
            Console.WriteLine($"Номер максимального элемента в массиве: [{row} , {colon}] ");

            Console.WriteLine($"Создание массива из файла");
            var filePath = AppDomain.CurrentDomain.BaseDirectory + "ArrayInit.txt";
            MyBinarArray binarArray = new MyBinarArray(filePath);
            Console.WriteLine(binarArray.ToString());

                 
            Console.ReadKey();
        }
    }
}
