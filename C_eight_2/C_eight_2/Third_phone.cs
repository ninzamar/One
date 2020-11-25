using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class Third_phone : Second_phone 
    {
        public override List<char> AvailableSymbols => new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+'};

        public int ScreenW { get; set; }
        public int ScreenH { get; set; }
        public double Screen_size { get; set; }
        public string Screen_color { get; set; }

        public virtual void Message()
        {
            Console.WriteLine($"Сообщение было отправлено на номер {EnterNumber()}");
        }

        public virtual void TakeMessage(string sender)
        {
            Console.WriteLine($"Вы получили сообщение от {sender}");
        }

        public Third_phone(string PhoneNum, int screenW, int screenH, double screen_size, string phone_color) : base(PhoneNum)
        {
            ScreenW = screenW;
            ScreenH = screenH;
            Screen_size = screen_size;
            Screen_color = phone_color;
        }
    }
}
