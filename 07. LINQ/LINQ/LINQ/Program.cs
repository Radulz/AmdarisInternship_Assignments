using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var s1 = new Student
            {
                firstname = "John",
                lastname = "McGregor",
                age = 19,
                country = "UK"
            };
            var s2 = new Student
            {
                firstname = "Radu",
                lastname = "Matei",
                age = 21,
                country = "Romania",
            };
            var s3 = new Student
            {
                firstname = "Alex",
                lastname = "Popescu",
                age = 20,
                country = "Romania",
            };
            var s4 = new Student
            {
                firstname = "Charles",
                lastname = "Sainz",
                age = 22,
                country = "France",
            };
            var s5 = new Student
            {
                firstname = "Rares",
                lastname = "joacabine",
                age = 21,
                country = "Romania",
            };
            var s6 = new Student
            {
                firstname = "Kate",
                lastname = "Shaw",
                age = 19,
                country = "UK",
            };
            var s7 = new Student
            {
                firstname = "Luis",
                lastname = "Enrique",
                age = 22,
                country = "Spain",
            };
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);

            var countryfilter = students.Where(x => x.country.Equals("Romania"));
            foreach(var s in countryfilter)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            var agefilter = students.OrderByDescending(a => a.age).GroupBy(a => a.age);

            foreach (var s in agefilter)
            {
                Console.WriteLine(s.Key + " years group.");
                Console.WriteLine($"Contains {s.Count()} students:");
                foreach(var val in s)
                {
                    Console.WriteLine($"{val.firstname} {val.lastname}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
