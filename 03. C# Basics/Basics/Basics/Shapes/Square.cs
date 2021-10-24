using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Shapes
{
    public class Square : Shape
    {
        public double length { get; set; }
        public Square(int l) : base("Square")
        {
            this.length = l;
        }

        public override double areaCalculator()
        {
            return length * length;
        }
        public override double perimeterCalculator()
        {
            return 4 * length;
        }
    }
}
