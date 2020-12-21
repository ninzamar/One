using System;

namespace C_eleven
{
    class MainAll
    {
        static void Main()
        {
            Conveyor conveyor = new Conveyor();
            Console.WriteLine("Вот вся информация: ");

            Console.WriteLine("\nПродукт #1 прошел все этапы: ");
            Product product1 = new Product();
            Console.WriteLine(product1);
            Console.WriteLine();
            AllPoints(conveyor).Invoke(product1);

            Console.WriteLine();

            Console.WriteLine("\nПродукт #2 частично прошел этапы: ");
            Product product2 = new Product();
            Console.WriteLine(product2);
            Console.WriteLine();
            HalfPoints(conveyor).Invoke(product2);

            Console.WriteLine();

            Console.WriteLine("\nПродукт #2 прошел подготовку: ");
            Product product3 = new Product();
            Console.WriteLine(product3);
            Console.WriteLine();
            PrePoints(conveyor).Invoke(product3);

            Conveyor.ConveyorDelegate operation = RequestForCostumer(conveyor);

            if (operation == null)
            {
                Console.WriteLine("Ничего не было сделано! ");
            }
            else
            {
                operation.Invoke(product3);
                Console.WriteLine(product3);
            }
            Console.ReadKey();
        }

        static Conveyor.ConveyorDelegate AllPoints(Conveyor conveyor)
        {
            Conveyor.ConveyorDelegate conveyorOperation = null;
            conveyorOperation += conveyor.RemoveDimensions;
            conveyorOperation += conveyor.Cutoff;
            conveyorOperation += conveyor.Exiled;
            conveyorOperation += conveyor.CutThread;
            conveyorOperation += conveyor.Drill;
            conveyorOperation += conveyor.Paint;
            conveyorOperation += conveyor.Test;
            conveyorOperation += conveyor.Pack;
            return conveyorOperation;
        }

        static Conveyor.ConveyorDelegate HalfPoints(Conveyor conveyor)
        {
            Conveyor.ConveyorDelegate conveyorOperation = null;
            conveyorOperation += conveyor.Test;
            conveyorOperation += conveyor.CutThread;
            conveyorOperation += conveyor.Paint;
            conveyorOperation += conveyor.Pack;
            return conveyorOperation;
        }

        static Conveyor.ConveyorDelegate PrePoints(Conveyor conveyor)
        {
            Conveyor.ConveyorDelegate conveyorOperation = null;
            conveyorOperation += conveyor.Test;
            conveyorOperation += conveyor.Pack;
            return conveyorOperation;
        }

        static Conveyor.ConveyorDelegate RequestForCostumer(Conveyor conveyor)
        {
            Conveyor.ConveyorDelegate conveyorOperation = null;
            ConsoleKey replay;
            while (true)
            {
                Console.Write("Хотите снять размеры? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.RemoveDimensions;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите отрезать? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Cutoff;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите заточить? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Exiled;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите нарезать резьбу? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.CutThread;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите просверлить? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Drill;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите покрасить? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Paint;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите протестировать? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Test;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("Хотите запаковать? [y/n]");
                replay = Console.ReadKey(false).Key;
                if (replay == ConsoleKey.Y)
                    conveyorOperation += conveyor.Pack;
                else if (replay != ConsoleKey.N)
                    continue;
                Console.WriteLine();
                break;
            }
            return conveyorOperation;
        }
    }
}
