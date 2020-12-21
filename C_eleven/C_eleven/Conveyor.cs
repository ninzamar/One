using System;

namespace C_eleven
{
    class Conveyor
    {
        public delegate void ConveyorDelegate(Product productInConveyor);

        public void RemoveDimensions(Product protuct)   //снять размеры
        {
            Product.RemovedDimensions = true;
        }


        public void Cutoff(Product product)     //отрезать
        {
            Product.Cuttedoff = true;
        }


        public void Exiled(Product product)     //заточить
        {
            Product.Exiladed = true;
        }


        public void CutThread(Product product)      //нарезать резьбу
        {
            Product.CuttedThread = true;
        }


        public void Drill(Product product)      //просверлить
        {
            Product. Drilled = true;
        }


        public void Paint(Product product)      //покрасить
        {
            Product.Painted = true;
        }


        public void Test(Product product)       //протестировать
        {
            Product.Tested = true;
        }


        public void Pack(Product product)       //запаковать
        {
            Product.Packed = true;
        }
    }
}
