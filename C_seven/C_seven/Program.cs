using System;
using System.Text;
using System.Collections.Generic;

namespace C_seven
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите сколько будет чисел: ");
            int amount;

            while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Допускаются значения только больше 0. Попробуйте ещё раз: ");
            }

            List<int> list = new List<int>(amount);

            for (int i = 0; i < list.Capacity; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                int number;

                while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 1)
                {
                    Console.Write("Вводите только 0 и 1: ");
                }
                list.Add(number);
            }

            Console.WriteLine();
            Console.WriteLine("Ваш список: ");

                foreach (int element in list)
                    Console.WriteLine(element);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Посчитаем количество 1 и 0: ");

            int zeroCounter = 0;
            int oneCounter = 0;

            foreach (int element in list)
                if (element == 0)
                    zeroCounter++;
                else oneCounter++;

            Console.WriteLine();
            Console.WriteLine($"Нули: {zeroCounter}");
            Console.WriteLine($"Единицы: {oneCounter}");
        }
    }
}
