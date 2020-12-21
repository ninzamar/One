using System;
using System.Collections.Generic;

namespace C_eleven_2
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            Random random = new Random();

            int numOfStud = 12;
            for (int i = 0; i < numOfStud; i++)
            {
                students.Add(new Student
                {
                    Age = random.Next(17, 26),
                    FirstName = GetRandomFirstName(random),
                    LastName = GetRandomLastName(random)
                }
                );
            }

            Console.WriteLine("Список всех студентов: ");
            students.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Студенты, которые старше 18: ");
            students.FindStudents(Student.AgeCheck).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Первая буква в имени \"А\": ");
            students.FindStudents(Student.FirstNameFLA).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Фамилия длинне 3 букв: ");
            students.FindStudents(Student.LastNameLT3).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Студенты, которые старше 18: ");
            students.FindStudents(s => s.Age >= 18).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Первая буква имени \"А\": ");
            students.FindStudents(s => s.FirstName?[0] == 'A').ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Фамилия длинне 3 букв");
            students.FindStudents(s => s.LastName?.Length > 3).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Возраст от 20 до 25");
            students.FindStudents(s => s.Age >= 20 && s.Age <= 25).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Имя \"Andrew\"");
            students.FindStudents(s => s.FirstName.Equals("Andrew")).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Фамилия \"Troelsen\"");
            students.FindStudents(s => s.LastName.Equals("Troelsen")).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.ReadKey();
        }

        static private string GetRandomFirstName(Random random)
        {
            string[] names = {
                "Nikolai",
                "Abdyhalim",
                "Hitler",
                "Limba",
                "Petro",
                "Andrew",
                "Liza",
                "Supp",
                "Karen",
                "Even",
                "Klara",
                "Steve", };
            return names[random.Next(names.Length)];
        }

        static private string GetRandomLastName(Random random)
        {
            string[] names = {
                "Kovalski",
                "Habib",
                "Hen",
                "Num",
                "Vadimich",
                "God",
                "Lur",
                "Whupt",
                "Troelsen",
                "Lat",
                "Poter",
                "Minecraft", };
            return names[random.Next(names.Length)];
        }
    }
}