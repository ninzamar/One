using System;
using System.Linq;
using System.Text;

namespace C_fourth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Работа с массивами ");
            Console.WriteLine("___________________");

            Console.Write("Введите размер массива: ");
            int elements = int.Parse(Console.ReadLine());
            int[] MyArray = new int[elements];

            for(int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"Введите элемент под номером {i}: ");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ваш массив: ");

            for(int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            Console.WriteLine("Поменяем местами max и min элементы: ");

            int MinIndex = Array.IndexOf(MyArray, MyArray.Min());
            int MaxIndex = Array.IndexOf(MyArray, MyArray.Max());

            int temp = MyArray[MinIndex];
            MyArray[MinIndex] = MyArray[MaxIndex];
            MyArray[MaxIndex] = temp;

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
        }
    }
}
