using System;

namespace C_eleven_2
{
    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        static public bool AgeCheck(Student student) => student.Age >= 18;
        static public bool FirstNameFLA(Student student) => student.FirstName?[0] == 'A';
        static public bool LastNameLT3(Student student) => student.LastName?.Length > 3;

        public override string ToString()
        {
            return $"  Имя:  {FirstName}" +
                   $"  Фамилия:  {LastName}" +
                   $"  Возраст:  {Age}";
        }
    }
}