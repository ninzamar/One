using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_individual
{
    class InformationAbout
    {
        private readonly List<Phone> _infoCollection;

        public InformationAbout()
        {
            _infoCollection = new List<Phone>
            {
                new Phone(2017, 449, "Samsung", new List<string>() {"blue", "black"}),
                new Phone(2019, 999, "iPhone", new List<string>() {"space grey", "silver"}),
                new Phone(2016, 299, "Huawei", new List<string>() {"rose", "red", "yellow"}),
                new Phone(2020, 299, "Yota", new List<string>() {"black", "white"}),
                new Phone(2018, 599, "Sony", new List<string>() {"bluesharp"}),
            };
        }

        public IEnumerable<Phone> GetPhones(Phone phone)
        {
            LinkedList<Phone> force = new LinkedList<Phone>();

            foreach (var _phone in _infoCollection)
            {
                if (phone.Color == null)
                    continue;

                bool colorMatch = false;

                foreach (var color in _phone.Color)
                {
                    if (phone.Color[0].ToLower() != color.ToLower())
                        colorMatch = true;
                }
                if (!colorMatch)
                    continue;

                if (phone.Year != 0 && _phone.Year != phone.Year)
                    continue;

                if (phone.Price != 0 && _phone.Price != phone.Price)
                    continue;

                if (phone.Name != "0" && _phone.Name.ToLower() != phone.Name.ToLower())
                    continue;

                force.AddFirst(_phone);
            }
            return force;
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder("Все доступные телефоны: ");
            Console.WriteLine("");

            for(int i = 0; i < _infoCollection.Count; i++)
            {
                information.Append($"Телефон №{i}:\t{_infoCollection[i]}");
                Console.WriteLine("");
            }
            return information.ToString();
        }
    }
}
