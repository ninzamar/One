using System;
using System.Text;

namespace C_fifth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Lab 5");
            Console.WriteLine("______");
            int[,] matrix = { { 8, 3, 2, 9 }, { 9, 9, 2, 8 }, { 9, 9, 2, 4} };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            Console.WriteLine();

            int i = 0;
            int j = 0;

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");    
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("1) Найдем минимальную сумму ряда и индекс ряда, в которой она находится: ");

            i = 0;
            j = 0;
            int sum1 = 0;
            for (j = 0; j < columns; j++)
            {
                sum1 += matrix[i, j];
            }
            Console.WriteLine($"Сумма первого ряда = {sum1}");

            i = 1;
            int sum2 = 0;
            for(j = 0; j < columns; j++)
            {
                sum2 += matrix[i, j];
            }
            Console.WriteLine($"Сумма второго ряда = {sum2}");

            i = 2;
            int sum3 = 0;
            for(j = 0; j < columns; j++)
            {
                sum3 += matrix[i, j];
            }
            Console.WriteLine($"Сумма третьего ряда = {sum3}");
            Console.WriteLine();

            if (sum1 < sum2 && sum1 < sum3)
            {
                Console.WriteLine($"Первый ряд имеет наименшую сумму. Она равна {sum1}!");
            }
            else if (sum2 < sum3 && sum2 < sum1)
            {
                Console.WriteLine($"Второй ряд имеет наименшую сумму. Она равна {sum2}!");
            }
            else
                Console.WriteLine($"Третий ряд имеет наименшую сумму. Она равна {sum3}!");


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2) Теперь найдем максимальную сумму и индекс по столбикам: ");
            Console.WriteLine();

            i = 0;
            j = 0;
            int sum4 = 0;
            for(i = 0; i < rows; i++)
            {
                sum4 += matrix[i, j];
            }
            Console.WriteLine($"Сумма первого столбика = {sum4}");

            j = 1;
            int sum5 = 0;
            for(i = 0; i < rows; i++)
            {
                sum5 += matrix[i, j];
            }
            Console.WriteLine($"Сумма второго столбика = {sum5}");

            j = 2;
            int sum6 = 0;
            for (i = 0; i < rows; i++)
            {
                sum6 += matrix[i, j];
            }
            Console.WriteLine($"Сумма третьего столбика = {sum6}");

            j = 3;
            int sum7 = 0;
            for (i = 0; i < rows; i++)
            {
                sum7 += matrix[i, j];
            }
            Console.WriteLine($"Сумма второго столбика = {sum7}");
            Console.WriteLine();

            if (sum4 > sum5 && sum4 > sum6)
            {
                Console.WriteLine($"Первый столбик имеет наибольшую сумму. Она равна {sum4}!");
            }
            else if (sum5 > sum6 && sum5 > sum4)
            {
                Console.WriteLine($"Второй столбик имеет наибольшую сумму. Она равна {sum5}!");
            }
            else if (sum6 > sum7 && sum6 > sum5)
            {
                Console.WriteLine($"Третий столбик имеет наибольшую сумму. Она равна {sum6}!");
            }
            else
                Console.WriteLine($"Четвертый столбик имеет наибольшую сумму. Она равна {sum7}!");
        }
    }
}
