using System;
using System.Text;

namespace Lab_1

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double Pi = 3.14159265;
            Console.WriteLine("Hello");

            double h;
            Console.WriteLine("Enter h: ");
            string str = System.Console.ReadLine();
            h = Convert.ToDouble(str);

            double r;
            Console.WriteLine("Enter r: ");
            string str1 = System.Console.ReadLine();
            r = Convert.ToDouble(str1);

            double v;
            v = (Pi * r * r) * h;
            Console.WriteLine($"V = {v}");
        }
    }
}