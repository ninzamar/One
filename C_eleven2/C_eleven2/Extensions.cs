using System;
using System.Collections.Generic;

namespace C_eleven_2
{
    static public class Extensions
    {
        static public List<Student> FindStudents(this List<Student> students, Student.StudentPredicateDelegate studentFindPredicate)
        {
            List<Student> results = new List<Student>();
            foreach (var student in students)
            {
                if (studentFindPredicate(student))
                    results.Add(student);
            }
            return results;
        }
    }
}