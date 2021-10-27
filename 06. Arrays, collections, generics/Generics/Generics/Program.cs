using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                name = "John",
                age = 16,
                mark = 8.55,
            };

            var s2 = new Student
            {
                name = "Alexa",
                age = 10,
                mark = 4.95,
            };

            var s3 = new Student
            {
                name = "John",
                age = 16,
                mark = 9.27,
            };

            var s4 = new Student
            {
                name = "Ionut",
                age = 17,
                mark = 7.89,
            };

            Collection<Student> v = new Collection<Student>();
            v.Add(s1);
            v.Add(s2);
            v.Add(s3);
            foreach(Student s in v.GetAll())
            {
                if(s != null)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(v.GetHashCode(s));
                }
                    
            }
            Console.WriteLine();
            Console.WriteLine(v.Equals(s1, s3));
            Console.WriteLine(v.GetStudent(2));
            Console.WriteLine();
            v.SetStudent(0, s4);
            v.SwapStudents(0, 2);
            foreach (Student s in v.GetAll())
            {
                if (s != null)
                {
                    Console.WriteLine(s);
                }

            }
            Console.WriteLine();
            v.Remove();
            foreach (Student s in v.GetAll())
            {
                if (s != null)
                {
                    Console.WriteLine(s);
                }

            }
        }
    }
}
