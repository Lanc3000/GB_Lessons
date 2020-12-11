using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
    3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
        Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
        
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    ArgumentException("Знаменатель не может быть равен 0");
    Добавить упрощение дробей.
 */

namespace L03HW03
{

    class Fraction {
        private int _numerator; //числитель (вверху)
        private int _denominator; //знаменатель
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            if(denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            else
                 _denominator = denominator;
        }

        public Fraction Add(Fraction y)
        {
            Fraction x = new Fraction();
            x._numerator = _numerator * y._denominator + _denominator * y._numerator;
            x._denominator = _denominator * y._denominator;
            return x;
        }
        public Fraction Sub(Fraction y)
        {
            Fraction x = new Fraction();
            x._numerator = _numerator * y._denominator - _denominator * y._numerator;
            x._denominator = _denominator * y._denominator;
            return x;
        }
        public Fraction Mult(Fraction y)
        {
            Fraction x = new Fraction();
            x._numerator = _numerator * y._numerator;
            x._denominator = _denominator * y._denominator;
            return x;
        }
        public Fraction Div(Fraction y)
        {
            Fraction x = new Fraction();
            x._numerator = _numerator * y._denominator;
            x._denominator = _denominator * y._numerator;
            return x;
        }
        
        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
        public static int GCD(int a, int b) //находим НОД
        {
            while (b != 0) {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        public  Fraction Simplification(Fraction y) {
            Fraction x = new Fraction();
            int comm = GCD(y._numerator, y._denominator);
            if (comm != 1 && comm != -1)
            {
                x._numerator = y._numerator / comm;
                x._denominator = y._denominator / comm;
                return x;
            }
            else
                return y;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Fraction fr1 = new Fraction(1, 3);
            Fraction fr2 = new Fraction(1, 2);

            Fraction fr3 = fr1.Add(fr2);
            Console.WriteLine($"{fr1} + {fr2} = {fr3}");
            Console.WriteLine();

            Fraction fr4 = fr2.Sub(fr1);
            Console.WriteLine($"{fr2} - {fr1} = {fr4}");
            Console.WriteLine();

            Fraction fr5 = fr2.Mult(fr1);
            Console.WriteLine($"{fr2} * {fr1} = {fr5}");
            Console.WriteLine();

            Fraction fr6 = fr2.Div(fr1);
            Console.WriteLine($"{fr2} / {fr1} = {fr6}");
            Console.WriteLine();

            Fraction fr7 = new Fraction(4, 12);
           
            Console.WriteLine($"{fr7} упрощается до {fr7.Simplification(fr7)}");

            // Fraction fr = new Fraction(5, 0);
            Console.ReadKey();
        }
    }
}
