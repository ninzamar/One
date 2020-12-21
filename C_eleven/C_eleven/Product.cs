using System;

namespace C_eleven
{
    class Product
    {
        static public bool RemovedDimensions { get; set; }
        static public bool Cuttedoff { get; set; }
        static public bool Exiladed { get; set; }
        static public bool CuttedThread { get; set; }
        static public bool Drilled { get; set; }
        static public bool Painted { get; set; }
        static public bool Tested { get; set; }
        static public bool Packed { get; set; }
        public override string ToString()
        {
            return
            $"RemovedDimensions\t:\t{ RemovedDimensions}" +
            $"\nCuttedoff\t\t:\t{Cuttedoff}" +
            $"\nExiladed\t\t:\t{Exiladed}" +
            $"\nCuttedThread\t\t:\t{CuttedThread}" +
            $"\nDrilled\t\t\t:\t{Drilled}" +
            $"\nTested\t\t\t:\t{Tested}" +
            $"\nPacked\t\t\t:\t{Packed}";
        }
    }
}
