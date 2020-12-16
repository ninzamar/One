using System;

namespace C_nine
{
    class Circle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex => 0;
        public override string NameOfObject { get; }
        public int Radius { get; set; }

        public Circle(string shapename)
        {
            Random random = new Random();
            Color = (ConsoleColor)random.Next(16);
            NameOfObject = shapename;
            Radius = random.Next(20);
        }

        public Circle(string shapename, int size)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(20);
            Radius = size;
        }

        public Circle(string shapename, int size, int color)
        {
            NameOfObject = shapename;
            Radius = size;
            Color = (ConsoleColor)color;
        }

        public override double Find_Perimetr() => Math.PI * (Radius * Radius);

        public override double Find_Square() => 2 * Math.PI * Radius;

        public override void Draw()
        {
            Console.WriteLine("\nВаша фигура: круг " +
                $"\nЕё название: {NameOfObject}" +
                $"\nКоличество вершин: {NumberVertex}" +
                $"\nРадиус: {Radius}" +
                $"\nПериметр: {Find_Perimetr()}" +
                $"\nПлощадь: {Find_Square()}");
            Console.ResetColor();
        }
    }
}
