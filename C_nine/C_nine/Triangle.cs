using System;

namespace C_nine
{
    class Triangle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex => 3;
        public override string NameOfObject { get; }
        public int SideLenght_1 { get; set; }
        public int SideLenght_2 { get; set; }

        public Triangle(string shapename)
        {
            Random random = new Random();
            NameOfObject = shapename;
            Color = (ConsoleColor)random.Next(16);
            SideLenght_1 = random.Next(20);
            SideLenght_2 = random.Next(SideLenght_1 * 2);
        }

        public Triangle(string shapename, int sideLenght_1, int sideLenght_2)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(16);
            SideLenght_1 = sideLenght_1;
            SideLenght_2 = sideLenght_2;
        }

        public Triangle(string shapename, int sideLenght_1, int sideLenght_2, int color)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)color;
            SideLenght_1 = sideLenght_1;
            SideLenght_2 = sideLenght_2;
        }

        public override double Find_Perimetr() => SideLenght_2 + SideLenght_1 * SideLenght_1;

        public override double Find_Square() => 0.5 * SideLenght_2 * Math.Sqrt(4 * SideLenght_1 ^ 2 - SideLenght_2 ^ 2);

        public override void Draw()
        {
            Console.WriteLine("\nВаша фигура: равнобедренный треугольник " +
                $"\nЕё название: {NameOfObject}" +
                $"\nКоличество вершин: {NumberVertex}" +
                $"\nЕё основа (см): {SideLenght_2}" +
                $"\nЕё боковые стороны (см): {SideLenght_1}" +
                $"\nПериметр: {Find_Perimetr()}" +
                $"\nПлощадь: {Find_Square()}");
            Console.ResetColor();
        }
    }
}
