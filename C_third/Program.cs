using System;
using System.Text;

namespace C_third
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            int num1 = Convert.ToInt32(number);

            if (num1 % 2 != 0)
            {
                Console.WriteLine("Это число непарное. ");
            }
            else
            {
                Console.WriteLine("Это число парное. ");
            }

            if (100 <= num1 && num1 < 1000)
            {
                Console.WriteLine("Это число есть трёхзначным! ");
            }
            else
            {
                Console.WriteLine("Это число не трёхзначное! ");
            }
        }
    }
}
