using System;

namespace C_nine
{
    class Square : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex  => 4;
        public override string NameOfObject { get; }
        public int SideLenght { get; set; }

        public Square(string shapename)
        {
            Random random = new Random();
            NameOfObject = shapename;
            Color = (ConsoleColor)random.Next(16);
            SideLenght = random.Next(20);
        }

        public Square(string shapename, int sideLenght)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(16);
            SideLenght = sideLenght;
        }

        public Square(string shapename, int sideLenght, int color)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)color;
            SideLenght = sideLenght;
        }

        public override double Find_Perimetr() => SideLenght * 4;

        public override double Find_Square() => (SideLenght) ^ 2;

        public override void Draw()
        {
            Console.WriteLine("\nВаша фигура: квадрат " +
                $"\nЕё название: {NameOfObject}" +
                $"\nКоличество вершин: {NumberVertex}" +
                $"\nДлинна сторон: {SideLenght}" +
                $"\nПериметр: {Find_Perimetr()}" +
                $"\nПлощадь: {Find_Square()}");
            Console.ResetColor();
        }
    }
}
