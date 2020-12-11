using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Тимур Самигуллин
1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 */
namespace L03HW01
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x) {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Substr(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi(Complex x) {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            string s = "";
            if (im < 0)
                s = $"z = {re}{im}i";
            else
                s = $"z = {re} + {im}i";
            return s;
        }
    }
    class ComplexCS
    {
        public double im;
        public double re;

        public ComplexCS(){}

        public ComplexCS(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        public ComplexCS Plus(ComplexCS x)
        {
            ComplexCS y = new ComplexCS();
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public ComplexCS Substr(ComplexCS x)
        {
            ComplexCS y = new ComplexCS();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public ComplexCS Multi(ComplexCS x)
        {
            ComplexCS y = new ComplexCS();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            string s = "";
            if (im < 0)
                s = $"z = {re}{im}i";
            else
                s = $"z = {re} + {im}i";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex cm1;
            cm1.re = 5;
            cm1.im = 2;

            Complex cm2;
            cm2.re = 1;
            cm2.im = 1;

            Complex cm3 = cm2.Substr(cm1);
            Console.WriteLine($"Вычитание(структура) {cm1} из {cm2}: \n{cm3}");
            Console.WriteLine("");

            Complex cm4 = cm2.Multi(cm1);
            Console.WriteLine($"Умножение(структура) {cm1} на {cm2}: \n{cm4}");
            Console.WriteLine("*********************************************");

            ComplexCS complexCS1 = new ComplexCS(5, 2);
            ComplexCS complexCS2 = new ComplexCS(1, 1);

            ComplexCS complexCS3 = complexCS2.Substr(complexCS1);
            Console.WriteLine($"Вычитание(класс) {complexCS1} из {complexCS2}: \n{complexCS3}");
            Console.WriteLine("");

            ComplexCS complexCS4 = complexCS2.Multi(complexCS1);
            Console.WriteLine($"Умножение(класс) {complexCS1} на {complexCS2}: \n{complexCS4}");

            Console.ReadKey();
        }
    }
}
