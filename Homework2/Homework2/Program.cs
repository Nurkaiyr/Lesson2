using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
            Fourth();
            Fifth();
            Sixth();
            Seventh();
            Eighth();
            Nineth();
            Tenth();
        }

        private static void Tenth()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");
            int b;
            Console.WriteLine("Введите значение b=");
            b = int.Parse(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            Console.WriteLine("\n\n");
            int a;
            Console.WriteLine("Введите значение a=");
            a = int.Parse(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.WriteLine("\n\n");
            int x;
            Console.WriteLine("Введите значение x=");
            x = int.Parse(Console.ReadLine());
            int y;
            Console.WriteLine("Введите значение y=");
            y = int.Parse(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private static void Nineth()
        {
            double i1, r1, u1, i2, r2, u2;
            Console.WriteLine("Введите сопротивление первого участка");
            r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение первого участка");
            u1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление второго участка");
            r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение второго участка");
            u2 = double.Parse(Console.ReadLine());
            i1 = u1 / r1;
            i2 = u2 / r2;
            if (i1 > i2) Console.WriteLine("В первом участке протекает меньший ток");
            if (i1 < i2) Console.WriteLine("Во втором участке протекает меньший ток");
            if (i1 == i2) Console.WriteLine("В первом участке и во втором участке ток одинаковый");
            Console.ReadKey();
        }

        private static void Eighth()
        {
            double p1, m1, v1, p2, m2, v2;
            Console.WriteLine("Введите массу первого тела:");
            m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем первого тела:");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела:");
            m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем второго тела:");
            v2 = double.Parse(Console.ReadLine());
            p1 = m1 / v1;
            p2 = m2 / v2;
            if (p1 > p2) Console.WriteLine("Плотность первого тела больше");
            if (p1 < p2) Console.WriteLine("Плотность второго тела больше");
            if (p1 == p2) Console.WriteLine("Плотность первого тела и второго тела равны");
            Console.ReadKey();
        }

        private static void Seventh()
        {
            int radius, side;
            double skrug, skvadrat;
            Console.WriteLine("Введите радиус круга: ");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата:");
            side = int.Parse(Console.ReadLine());
            skrug = Math.PI * Math.Pow(radius, 2);
            skvadrat = Math.Pow(side, 2);
            if (skrug > skvadrat) Console.WriteLine("Площадь круга больше чем площадь квадрата");
            if (skrug < skvadrat) Console.WriteLine("Площадь квадрата больше чем площадь круга");
            if (skrug == skvadrat) Console.WriteLine("Площадь квадрата и площадь круга равны");
            Console.ReadKey();
        }

        private static void Sixth()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            Console.WriteLine(a || b);
            Console.WriteLine(a && b);
            Console.WriteLine(b || c);
            Console.ReadKey();
        }

        private static void Fifth()
        {
            int desyat = 10;
            int chislo, desyatki, edinicy, summa, proizvedenie;
            Console.WriteLine("Введите 2х значное число: ");
            chislo = int.Parse(Console.ReadLine());
            desyatki = chislo / desyat;
            edinicy = chislo % desyat;
            summa = desyatki + edinicy;
            proizvedenie = desyatki * edinicy;

            Console.WriteLine("Число десятков: " + desyatki);
            Console.WriteLine("Число единиц: " + edinicy);
            Console.WriteLine("Сумма цифр: " + summa);
            Console.WriteLine("Произведение цифр: " + proizvedenie);
        }

        private static void Fourth()
        {
            int nedeli = 7;
            int dni = 234;
            int weeks;
            Console.WriteLine("С некоторого момента прошло 234 дня");
            weeks = dni / nedeli;
            Console.WriteLine("С тех пор прошло полных недель: " + weeks);
            Console.ReadKey();
        }

        private static void Third()
        {
            double cmtom = 0.01;
            double cm, m;
            Console.WriteLine("Введите расстояние в сантиметрах:");
            cm = double.Parse(Console.ReadLine());
            m = cm * cmtom;
            Console.WriteLine("Расстояние в метрах" + m);
            Console.ReadKey();
        }

        private static void Second()
        {
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            Console.ReadKey();
        }

        private static void First()
        {
            Console.WriteLine("1  2  3");
            Console.ReadKey();
        }
    }
}
