using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_nine
{
    class Picture : IDraw
    {
        private readonly List<Shape> _shapes;
        public int ShapesCount => _shapes.Count;

        public Picture()
        {
            _shapes = new List<Shape>();
        }

        public Picture(int shapesnumber)
        {
            _shapes = new List<Shape>(shapesnumber);
        }

        public void AddShapes(Shape shape)
        {
            _shapes.Add(shape);
        }

        public bool DeleteShape(string name, string type, double square)
        {
            if (type.Equals("Square", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Square && s.NameOfObject == name && s.Find_Square() > square);
                return true;
            }
            if (type.Equals("Circle", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Circle && s.NameOfObject == name && s.Find_Square() > square);
                return true;
            }
            if (type.Equals("Triangle", StringComparison.CurrentCultureIgnoreCase))
            {
                _shapes.RemoveAll(s => s is Triangle && s.NameOfObject == name && s.Find_Square() > square);
                return true;
            }
            return false;
        }

        public Shape this[int index] => _shapes.ElementAtOrDefault(index);

        public void Draw()
        {
            foreach (var shape in _shapes)
                shape.Draw();
        }
    }
}
