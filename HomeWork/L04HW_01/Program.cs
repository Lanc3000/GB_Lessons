using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Тимур Самигуллин
    1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
    В данной задаче под парой подразумевается два подряд идущих элемента массива. 
    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
 */
namespace L04HW_01
{

    class Program
    {

        static bool isDiv(int num)
        {
            if (num % 3 == 0)
                return true;
            else
                return false;
        }
        static void CoupleSearcher(int[] arr) {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (isDiv(arr[i - 1]) || isDiv(arr[i]))
                    count++;
            }
            Console.WriteLine($"Количество пар - {count}");
        }
        static int[] ReturnArr(int leng)
        {
            int[] ar = new int[leng];
            Random rnd = new Random();
            
            for(int i = 0; i < leng; i++)
            {
                ar[i] = rnd.Next( -10000, 10000);
            }
            return ar;
        }
        static void Main(string[] args)
        {
            int[] array = ReturnArr(10);
            foreach(int el in array)
            {
                Console.Write($"{el} ");
                
            }
            Console.WriteLine();

            CoupleSearcher(array);

            int[] array1 = { 3, -3, 4, 4, 12, -12 };
            foreach (int el in array1) {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            CoupleSearcher(array1);

            Console.ReadKey();
        }
    }
}
