using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace C_ten
{
    public static class Nextt
    {
        public static int Reverse(this int znach)
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


        public static string Reverse(this string znach)
        {
            string Rever = string.Empty;
            for (int i = znach.Length - 1; i >= 0; i--)
            {
                Rever += znach[i];
            }
            return Rever;
        }


        public static string SplitReverse(this string znach)
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


        public static double SplitReverse(this double znach) =>
    Double.Parse(SplitReverse(znach.ToString(CultureInfo.CurrentCulture)));

        public static T[] Reverse<T>(this T[] array)
        {
            T[] newArray = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
                {
                    newArray[i] = array[j];
                }
            return newArray;
        }


        public static void PrintArrayEvenOdd(this int[] array)
        {
            List<int> oddElements = array.Where(el => el % 2 == 0).ToList();
            oddElements.ForEach(el => Console.Write(el + " "));
            array.Except(oddElements).ToList().ForEach(el => Console.Write(el + " "));
        }
    }
}