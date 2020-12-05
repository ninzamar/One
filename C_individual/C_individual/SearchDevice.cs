using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_individual
{
    class SearchDevice
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            InformationAbout informationAbout = new InformationAbout();
            Console.WriteLine(informationAbout);

            int year;
            int price;
            string name;
            string color;

            do
            {
                Console.WriteLine("Меню выбора телефона (пишите на англ. языке)");
                Console.WriteLine("Введите название: ");
                name = Console.ReadLine();

                Console.WriteLine("Введите год выпуска: ");
                while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
                    Console.WriteLine("Неккоректный ввод, ещё раз: ");

                Console.WriteLine("Введите цвет: ");
                color = Console.ReadLine();

                Console.WriteLine("Введите цену: ");
                while (!int.TryParse(Console.ReadLine(), out price) || price < 0)
                    Console.WriteLine("Неккоректный ввод, ещё раз: ");

                List<Phone> force = informationAbout.GetPhones(new Phone(year, price, name, new List<string> { color })).ToList();
                //List<string> color, int year, int price, string name
                //(new Phone((new List<string> { color }).ToList(), year, price, name));

                if (!force.Any())
                {
                    Console.WriteLine("Нету такого телефона. ");
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine("Подходящие под запрос телефоны: ");
                for (int i = 0; i < force.Count(); i++)
                    Console.WriteLine($"Телефон №{i+1}:\n{force.ElementAt(i)} ");
            } while (true);
        }
    }
}
