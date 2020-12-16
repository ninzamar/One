using System;

namespace C_nine
{
    abstract class Shape
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract int NumberVertex { get; }
        public abstract string NameOfObject { get; }
        public abstract double Find_Square();
        public abstract double Find_Perimetr();
        public abstract void Draw();
    }
}
