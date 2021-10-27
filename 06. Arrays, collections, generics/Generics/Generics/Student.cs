using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public double mark { get; set; }

        public Student()
        {

        }
        public override string ToString()
        {
            return name + " " + age + " " + mark;
        }

    }
}
