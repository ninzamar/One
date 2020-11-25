using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class Second_phone : First_phone
    {
        public override List<char> AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#' };

        public Second_phone(string PhoneNum) : base(PhoneNum)
        { }

        public override void TakeCall(string callingNowNumber)
        {
            Console.WriteLine($"Входящий звонок с номера {callingNowNumber}");
        }
    }
}
