using System;
using System.Linq;
using System.Text;

namespace C_eight
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Garage garage = new Garage();

            while (true)
            {
                Console.WriteLine("Выберите что вы хотите сделать: ");
                Console.WriteLine(
                    "\t1. Добавить машину\n " +
                    "\t2. Выкинуть машину к чертям\n " +
                    "\t3. Взять машину покататься\n " +
                    "\t4. Просмотреть весь гараж\n " +
                    "\t5. Уйти\n ");

                int choose;
                while(!int.TryParse(Console.ReadLine(), out choose) || choose < 0 || choose > 5)
                {
                    Console.WriteLine("Некорректный ввод, ещё раз: ");
                }

                if (choose == 5)   //выход
                    return 0;

                else if (choose == 1)    //показать содержимое гаража
                {
                    string n_name;
                    string n_color;
                    int n_speed;
                    int n_year;

                    Console.WriteLine("Пожалуйста, укажите данные о машине --> ");
                    Console.WriteLine();

                    Console.WriteLine("Введите название машини: ");
                    do
                    {
                        n_name = Console.ReadLine();
                        if (string.IsNullOrEmpty(n_name))
                            Console.Write("Некорректный ввод, ещё раз: ");
                        else break;
                    } while (true);

                    Console.WriteLine("Введите цвет машины: ");
                    do
                    {
                        n_color = Console.ReadLine();
                        if (string.IsNullOrEmpty(n_color))
                            Console.Write("Некорректный ввод, ещё раз: ");
                        else break;
                    } while (true);

                    Console.WriteLine("Введите скорость машины: ");
                    while (!int.TryParse(Console.ReadLine(), out n_speed) || n_speed <= 0)
                        Console.Write("Некорректный ввод. Скорость не может равняться 0, или быть меньше 0. Ещё раз: ");

                    Console.WriteLine("Введите год выпуска машины: ");
                    while (!int.TryParse(Console.ReadLine(), out n_year) || n_year <= 0)
                        Console.Write("Некорректный ввод. Год выпуска не может равняться 0, или быть меньше 0. Ещё раз: ");

                    Car redictingCar = new Car(n_name, n_color, n_speed, n_year);
                    garage.AddCar(redictingCar);
                    Console.WriteLine("Машина была добавлена в гараж!\n ");
                }

                else if (choose == 4)    //показать всё
                {
                    Console.WriteLine(garage);
                }

                else
                {
                    string n_name;
                    string n_color;
                    int n_speed;
                    int n_year;

                    Console.WriteLine("Выбор машини ");

                    Console.Write("Введите название машины: ");
                    n_name = Console.ReadLine();

                    Console.Write("Введите цвет машины: ");
                    n_color = Console.ReadLine();

                    Console.WriteLine("Введите скорость машины: ");
                    while (!int.TryParse(Console.ReadLine(), out n_speed) || n_speed < 0)
                        Console.Write("Некорректный ввод, ещё раз: ");

                    Console.WriteLine("Введите год выпуска машины: ");
                    while (!int.TryParse(Console.ReadLine(), out n_year) || n_year < 0)
                        Console.Write("Некорректный ввод, ещё раз: ");

                    var choise = garage.GetCars(new Car(n_name, n_color, n_speed, n_year));
                    if (choise.Count() < 1)
                    {
                        Console.WriteLine("Такая машина не найдена! ");
                        continue;
                    }

                    Console.WriteLine("Машини с похожими характеристиками: ");
                    for (int i = 0; i < choise.Count(); i++)
                        Console.WriteLine($"Машина номер {i + 1}:\n{choise.ElementAt(i)}");

                    if (choose == 2)    //выкинуть
                    {
                        if (choise.Count() > 1)
                        {
                            Console.WriteLine("Выберите машину по номеру\n ");
                            int chsNum;
                            
                            while (!int.TryParse(Console.ReadLine(),  out chsNum) || chsNum <= 0 || chsNum > choise.Count())
                            {
                                Console.Write("Некорректный ввод, ещё раз: ");
                            }
                            garage.RemoveCar(choise.ElementAt(chsNum - 1));
                        }
                        else
                            garage.RemoveCar(choise.ElementAt(0));
                        Console.WriteLine("Машина выкинута на свалку  :( ");
                    }

                    else if (choose == 3)    //покататься
                    {
                        if (choise.Count() > 1)
                        {
                            Console.WriteLine("Выберите машину по номеру: ");
                            int chsNum;
                            while (!int.TryParse(Console.ReadLine(), out chsNum) || chsNum <= 0 || chsNum > choise.Count())
                            {
                                Console.Write("Некорректный ввод, ещё раз: ");
                            }
                            choise.ElementAt(chsNum - 1).GetCar();
                        }
                        else
                            choise.ElementAt(0).GetCar();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}