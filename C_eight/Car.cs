using System;

namespace C_eight
{
    class Car
    {
        public string name { get; }
        public string color { get; }
        public int speed { get; }
        public int year { get; }

        public Car(string n_name, string n_color, int n_speed, int n_year)
        {
            name = n_name;
            color = n_color;
            speed = n_speed;
            year = n_year;
        }

        public void GetCar() => Console.WriteLine($"Вы взяли машину {color} {name} {year}");

        public override string ToString() => $"\tНазвание: {name}\n\tЦвет: {color}\n\tСкорость: {speed}\n\tГод выпуска: {year}\n";
    }
}