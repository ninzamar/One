using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class First_phone
    {
        public string PhoneNumber { set; get; }
        public virtual List<char>AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public First_phone(string PhoneNum)
        {
            PhoneNumber = PhoneNum;
        }

        protected string EnterNumber()
        {
            Console.WriteLine("Введите номер телефона абонента:");
            do
            {
                bool invalid = false;
                string number = Console.ReadLine();

                foreach (char symbol in number)
                    if (!AvailableSymbols.Contains(symbol))
                    {
                        invalid = true;
                        break;
                    }
                if (invalid)
                {
                    Console.WriteLine("Неккоректный ввод, ещё раз: ");
                    continue;
                }
                return number;
            } while (true);
        }
        public virtual void TakeCall(string callingNowNumber)
        {
            Console.WriteLine($"Входящий звонок");
        }
        public virtual void Call()
        {
            Console.WriteLine($"Вызов на номер {EnterNumber()}");
        }
    }
}
