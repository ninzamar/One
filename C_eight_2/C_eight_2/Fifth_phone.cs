using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class Last_phone : Fourth_phone
    {
        public int Cameras { get; set; }
        public int MaxTouchAbility { get; set; }
        public bool TouchAbility { get; set; }

        public Last_phone(int maxTouchAbility, int camerasNum, string PhoneNum, int screenW, int screenH, double screen_size, string phone_color, int screen_colors_q, string another_phone_num = null) : base(PhoneNum, screenW, screenH, screen_size, phone_color, screen_colors_q, another_phone_num)
        {
            Cameras = camerasNum;
            MaxTouchAbility = maxTouchAbility;

            if (MaxTouchAbility > 0)
            {
                TouchAbility = true;
            }
        }

        public void DoPhoto()
        {
            if(Cameras == 1)
            {
                Console.WriteLine($"Вы сделали фотографию на обычную камеру ");
            }

            else if (Cameras > 1)
            {
                int chooseCamera;
                Console.WriteLine($"С помощью какой камеры вы хотите сделать фото? (у вас всего {Cameras}): ");
                while(!int.TryParse(Console.ReadLine(), out chooseCamera) || chooseCamera < 1 || chooseCamera > Cameras)
                {
                    Console.WriteLine($"В телефоне всего {Cameras}! Выбирите одну из них: ");
                }
                Console.WriteLine($"Вы сделали фото на {chooseCamera} ");
            }

            else
                Console.WriteLine("У телефона не обнаружены камеры! ");
        }

        public void RecordVideo()
        {
            if (Cameras == 1)
            {
                Console.WriteLine($"Видео снято на обычную камеру ");
            }

            else if (Cameras > 1)
            {
                int chooseCamera;
                Console.WriteLine($"С помощью какой камеры вы хотите снять видео? (у вас всего {Cameras}): ");
                while (!int.TryParse(Console.ReadLine(), out chooseCamera) || chooseCamera < 1 || chooseCamera > Cameras)
                {
                    Console.WriteLine($"В телефоне всего {Cameras}! Выбирите одну из них: ");
                }
                Console.WriteLine($"Вы записали видео на {chooseCamera} ");
            }

            else
                Console.WriteLine("У телефона не обнаружены камеры! ");
        }
    }
}
