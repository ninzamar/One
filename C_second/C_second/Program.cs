using System;
using System.Text;

namespace C_second
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
         
            Console.WriteLine("Enter k: ");
            string Number1 = Console.ReadLine();
            double num = Convert.ToDouble(Number1);
            double Formula = ((Math.Pow(-1, num * num + 1)) * (num * num) - 2) / (3 * (num * num) - 2 * num);
            Console.WriteLine($"Result: {Formula}");
        }
    }
}
