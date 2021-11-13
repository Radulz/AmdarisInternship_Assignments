using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Shapes
{
    public abstract class Shape
    {
        public string name { get; set; }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double areaCalculator();
        public abstract double perimeterCalculator();
    }
}
