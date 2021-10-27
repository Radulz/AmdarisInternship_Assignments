using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string country { get; set; }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"{firstname} {lastname} {age} {country}";
        }
    }
}
