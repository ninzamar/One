using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class Fourth_phone : Third_phone
    {
        public bool Twin_sim { get; set; }
        public int Screen_colors_q { get; set; }
        public string Another_phone_num { get; set; }

        public Fourth_phone(string PhoneNum, int screenW, int screenH, double screen_size, string phone_color, int screen_colors_q, string another_phone_num = null) : base(PhoneNum, screenW, screenH, screen_size, phone_color)
        {
            Another_phone_num = another_phone_num;
            Screen_colors_q = screen_colors_q;

            if (Another_phone_num != null)
            {
                Twin_sim = true;
            }
        }

        public virtual void Accept_mms(string senderPhoneNumber)
        {
            Console.WriteLine($"Входящее MMS сообщение от {senderPhoneNumber}");
        }

        public override void Message()
        {
            if (!Twin_sim)
            {
                base.Message();
            }

            else
            {
                int choose_sim_card;
                Console.Write("Отправить сообщение с (1 или 2) sim карты: ");
                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                    Console.WriteLine("Некорректный ввод, попробуйте снова: ");
                Console.WriteLine($"SMS сообщение отправлено с номера: {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)} на номер: {EnterNumber()}");
            }
        }
        public virtual void Message_MMS()
        {
            if (!Twin_sim)
            {
                Console.WriteLine($"Вы отправили MMS на номер: {EnterNumber()}");
            }

            else
            {
                int choose_sim_card;
                Console.Write("Отправить MMS сообщение с (1 или 2) sim карты: ");
                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                    Console.WriteLine("Некорректный ввод, попробуйте снова: ");
                Console.WriteLine($"MMS сообщение отправлено с номера {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)} на номер {EnterNumber()}");
            }
        }

        public override void Call()
        {
            if (!Twin_sim)
            {
                base.Call();
            }

            else
            {
                int choose_sim_card;
                Console.Write("Сделать вызов с (1 или 2) sim карты: ");
                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                    Console.WriteLine("Некорректный ввод, ещё раз: ");
                Console.WriteLine($"Вы позвонили с номера: {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)} на номер: {EnterNumber()}");
            }
        }
    }
}
