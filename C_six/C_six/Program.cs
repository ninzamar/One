using System;
using System.Text;

namespace C_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int Numbers = 123;
            Console.WriteLine("Задание 1: \t" + Reverse(Numbers));
            Console.Write(Reverse(Numbers));
            Console.WriteLine();

            string Str = "Задание 2: Это тестовая строка ";
            Console.Write(Reverse(Str));
            Console.WriteLine();

            double Fraction = 145.970;
            Console.WriteLine("Задание 3: \t");
            Console.Write(Convert.ToDouble(SplitReverse(Fraction)));
            Console.WriteLine();

            string Magic = "Opa (12) a chto (71) eto tyt y (50) nas";
            Console.WriteLine("Задание 4: \t");
            Console.Write(SplitReverse(Magic));

            Console.WriteLine();

            Console.WriteLine("Задание 6.1: \t");
            Console.Write(RRever(Numbers));
            Console.WriteLine();

            Console.WriteLine("Задание 6.2: \t");
            Console.Write(RRever(Str));
            Console.WriteLine();

            Console.WriteLine("Задание 6.3: \t");
            Console.Write(Convert.ToDouble(RecurseSplitReverse(Fraction)));
            Console.WriteLine();

            Console.WriteLine("Задание 6.4: \t");
            Console.Write(RecurseSplitReverse(Magic));
            Console.WriteLine();


            Console.WriteLine("Задание 7: \t");
            int[] RWR = new int[6] { 7, 4, 6, 9, 1, 0 };
            var RevWithoutR = Rever(RWR);
            for (int i = 0; i < RevWithoutR.Length / 2; i++)
            {
                Console.WriteLine("\t\t");
                Console.Write(RevWithoutR[i]);
            }

            Console.WriteLine("Задание 8.1: \t");
            int[] newR = new int [6] { 7, 4, 6, 9, 1, 0 };
            Rever(ref newR);
            for(int i = 0; i < newR.Length; i++)
            {
                Console.WriteLine("\t\t");
                Console.Write(newR[i]);
            }

            Console.WriteLine("Задание 8.2: \t");
            int[] newR2 = new int[6] { 7, 4, 6, 9, 1, 0 };
            int[] newNR2 = null;
            Rever(newR2,out newNR2);
            for (int i = 0; i < newNR2.Length; i++)
            {
                Console.WriteLine("\t\t");
                Console.Write(newNR2[i]);
            }
        }


        static int Reverse(int znach)
        {
            int Rever = 0;
            while (znach > 0)
            {
                int remainded = znach % 10;
                Rever = (Rever * 10) + remainded;
                znach = znach / 10;
            }
            return Rever;
        }
        
        static string Reverse(string znach)
        {
            string Rever = string.Empty;
            for (int i = znach.Length - 1; i >= 0; i--)
            {
                Rever += znach[i];
            }
            return Rever;
        }
        static double SplitReverse(double znach) =>
            Double.Parse(SplitReverse(znach.ToString()));

        static string SplitReverse(string znach)
        {
            string rever = string.Empty;
            var strings = znach.Split(',');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                rever += Reverse(strings[i]) + ','; //tmp = rever+reverse(strings[i]) + ',';
            }
            rever += Reverse(strings[strings.Length - 1]);
            return rever;
        }

        static int RRever(int value, int rever = 0)
        {
            if (value == 0)
            return rever;
            int remainded = value % 10;
            rever = (rever * 10) + remainded;
            return RRever(value / 10, rever);

            /*
            if (value == 0)     //up
                return rever;
            */
        }

        static string RRever(string znach)
        {
            if (znach.Length <= 0)
            return znach;
            return znach[znach.Length - 1] + RRever(znach.Substring(0, znach.Length - 1));
        }
        static double RecurseSplitReverse(double znach) => Double.Parse(RecurseSplitReverse(znach.ToString()));
        static string RecurseSplitReverse(string znach)
        {
            string rever = string.Empty;
            var strings = znach.Split(',');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                rever += RRever(strings[i]) + ',';
            }
            rever += RRever(strings[strings.Length - 1]);
            return znach;
        }

        static T[] Rever<T>(T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArr[i] = array[j];
            }
            return newArr;
        }

        static void Rever<T>(ref T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                newArr[i] = array[j];
            }
            array = newArr;
        }

        static void Rever<T>(T[] array, out T[] newArray)
        {
            newArray = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                newArray[i] = array[j];
            }
        }
    }
}