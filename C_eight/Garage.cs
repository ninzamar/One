using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace C_eight
{
    class Garage
    {
        private List<Car> Cars { get; }


        public Garage() //лист новых
        {
            Cars = new List<Car>();
        }


        public void AddCar(Car vehicle) => Cars.Add(vehicle);   //добавляем машину


        public void RemoveCar(Car vehicle)  //удаляем машину
        {
            foreach (var car1 in Cars.ToArray())
                if(vehicle == car1)
                {
                    Cars.Remove(car1);
                    return;
                }
        }


        public IEnumerable<Car> GetCars(Car vehicle)    //делаем выбор через name, color...
        {
            LinkedList<Car> choise = new LinkedList<Car>();

            foreach(var car1 in Cars)
            {
                if (vehicle.name != "0" && car1.name != vehicle.name)
                    continue;

                else if (vehicle.color != "0" && car1.color != vehicle.color)
                    continue;

                else if (vehicle.speed != 0 && car1.speed != vehicle.speed)
                    continue;

                else if (vehicle.year != 0 && car1.year != vehicle.year)
                    continue;

                choise.AddFirst(car1);
            }
            return choise;
        }


        public override string ToString()   //override на всякий случай
        {
            if (Cars.Count() <= 0)
                //Console.WriteLine("пусто");
                return "В гараже пусто! ";

            StringBuilder vehicles = new StringBuilder();

            for(int i = 0; i < Cars.Count(); i++)
            {
                vehicles.Append($"Машина номер {i + 1}:\n{Cars[i]}");
            }
            return vehicles.ToString();
        }
    }
}