using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using C_ten;

namespace C_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int Numbers = 123;
            Console.WriteLine("Задание 1: \t" + Numbers.Reverse());
            Console.WriteLine();

            string Str = "Задание 2: Это тестовая строка ";
            Console.Write(Str.Reverse());
            Console.WriteLine();

            double Fraction = 145.970;
            Console.WriteLine("Задание 3: \t");
            Console.Write(Convert.ToDouble(Fraction.SplitReverse()));
            Console.WriteLine();

            string Magic = "Opa (12) a chto (71) eto tyt y (50) nas";
            Console.WriteLine("Задание 4: \t");
            Console.Write(Magic.SplitReverse());

            Console.WriteLine();

            Console.WriteLine("Задание 7: \t");
            int[] RWR = new int[6] { 7, 4, 6, 9, 1, 0 };
            var RevWithoutR = RWR.Reverse();
            for (int i = 0; i < RevWithoutR.Length; i++)
            {
                Console.WriteLine("\t\t");
                Console.Write(RevWithoutR[i]);
            }
            Console.WriteLine();

            int[] var6 = { 5, 7, 1, 1, 0, 9 };
            Console.Write("Задание варианта 6: ");
            var6.PrintArrayEvenOdd();
        }
    }
}