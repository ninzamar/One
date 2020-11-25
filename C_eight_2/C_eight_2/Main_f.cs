using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_eight_2
{
    class Main_f
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;



            Console.WriteLine("Дисковый телефон: ");
            First_phone first_phone = new First_phone("001");
            Console.Write("Символы: ");
            foreach (var sym in first_phone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {first_phone.PhoneNumber}");
            first_phone.Call();
            first_phone.TakeCall("101");
                Console.WriteLine(new string('_', 20));



            Console.WriteLine("Кнопочный телефон: ");
            Second_phone second_phone= new Second_phone("002");
            Console.Write("Символы: ");
            foreach (var sym in second_phone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {second_phone.PhoneNumber}");
            second_phone.Call();
            second_phone.TakeCall("911");
                Console.WriteLine(new string('_', 20));



            Console.WriteLine("Чёрно-белый телефон: ");
            Third_phone third_phone = new Third_phone("003", 80, 130, 4.7, "Металлический розовый");
            Console.Write("Символы: ");
            foreach (var sym in third_phone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {third_phone.PhoneNumber}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в пикселях: ");
            Console.WriteLine($"\tШирина экрана: {third_phone.ScreenW}");
            Console.WriteLine($"\tВысота экрана: {third_phone.ScreenH}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в дюймах: ");
            Console.WriteLine($"\tРазмер экрана: {third_phone.Screen_size}");
            Console.WriteLine();
            Console.WriteLine($"\tЦвет телефона: {third_phone.Screen_color}");
            third_phone.Call();
            third_phone.TakeCall("911");
            third_phone.Message();
            third_phone.TakeMessage("003");
                Console.WriteLine(new string('_', 20));



            Console.WriteLine("Телефон с цветным экраном:");
            Fourth_phone fourth_phone = new Fourth_phone("004", 120, 250, 5.5, "Черный", 80000000, "228");
            Console.Write("Символы: ");
            foreach (var sym in fourth_phone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {fourth_phone.PhoneNumber}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в пикселях: ");
            Console.WriteLine($"\tШирина экрана: {fourth_phone.ScreenW}");
            Console.WriteLine($"\tВысота экрана: {fourth_phone.ScreenH}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в дюймах: ");
            Console.WriteLine($"\tРазмер экрана: {fourth_phone.Screen_size}");
            Console.WriteLine();
            Console.WriteLine($"\tЦвет телефона: {fourth_phone.Screen_color}");
            Console.WriteLine();
            Console.WriteLine($"Количество sim карт в телефоне: {(fourth_phone.Twin_sim ? 2 : 1)}");
            Console.WriteLine();
            Console.WriteLine($"Второй номер телефона: {(fourth_phone.Twin_sim ? fourth_phone.Another_phone_num : "-")} ");
            fourth_phone.Call();
            fourth_phone.TakeCall("004");
            fourth_phone.Message();
            fourth_phone.TakeMessage("004");
            fourth_phone.Message_MMS();
            fourth_phone.Accept_mms("004");
                Console.WriteLine(new string('_', 20));



            Console.WriteLine("Смартфон:");
            Last_phone last_phone = new Last_phone(139000000, 4, "005", 350, 760, 6.8, "серебристая сталь", 4340000, "0055");

            Console.Write("Символы: ");
            foreach (var sym in last_phone.AvailableSymbols)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {last_phone.PhoneNumber}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в пикселях: ");
            Console.WriteLine($"\tШирина экрана: {last_phone.ScreenW}");
            Console.WriteLine($"\tВысота экрана: {last_phone.ScreenH}");
            Console.WriteLine();
            Console.WriteLine("Измеряется в дюймах: ");
            Console.WriteLine($"\tРазмер экрана: {last_phone.Screen_size}");
            Console.WriteLine();
            Console.WriteLine($"Цвет телефона: {last_phone.Screen_color}");
            Console.WriteLine();
            Console.WriteLine($"Количество sim карт в телефоне: {(last_phone.Twin_sim ? 2 : 1)}");
            Console.WriteLine();
            Console.WriteLine($"Второй номер телефона: {(last_phone.Twin_sim ? last_phone.Another_phone_num : "-")} ");
            Console.WriteLine();
            Console.WriteLine($"Сенсорный экран: {(last_phone.TouchAbility ? "есть" : "нету")}");
            Console.WriteLine();
            Console.WriteLine($"Максимальное количество касаний: {last_phone.MaxTouchAbility}");
            Console.WriteLine();
            Console.WriteLine($"Количество камер: {last_phone.Cameras}");
            Console.WriteLine();
            last_phone.Call();
            last_phone.TakeCall("005");
            last_phone.Message();
            last_phone.TakeMessage("005");
            last_phone.Message_MMS();
            last_phone.Accept_mms("005");
            last_phone.DoPhoto();
            last_phone.RecordVideo();

            Console.WriteLine();
            Console.WriteLine("Программа готова к закрытию. Пожалуйста, нажмите любую клавишу... ");
            Console.ReadLine();
        }
    }
}
