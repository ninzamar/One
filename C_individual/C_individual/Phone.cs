using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_individual
{
    class Phone
    {
        public int Year;
        public int Price;
        public string Name;
        public readonly List<string> Color;

        public Phone(int year, int price, string name, List<string> color)
        {
            Year = year;
            Price = price;
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder($"\t Телефон марки: {Name}\n" + $"\t Год выпуска: {Year}\n" + "\t Доступные цвета: ");

            foreach (var color in Color)
                information.Append(color + " ");

            Console.WriteLine("");
            information.Append($"Цена: {Price}");

            return information.ToString();
        }
    }
}
