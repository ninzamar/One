using System;

namespace C_nine
{
    class MainFile
    {
        static void Main()
        {
            Picture picture = new Picture();
            picture.AddShapes(new Triangle("TRNGL_1"));

            picture.AddShapes(new Square("SQR_1", 10, 10));

            picture.AddShapes(new Circle("CRCL_1"));
            picture.AddShapes(new Circle("CRCL_2", 2));
            picture.AddShapes(new Circle("CRCL_3", 5, 2));

            picture.Draw();
            Console.WriteLine();

            picture[2].Draw();
            Console.WriteLine();

            picture.DeleteShape("SQR_1", "Square", 20);
            Console.WriteLine();

            picture[2].Draw();

            Console.ReadKey();
        }
    }
}
