using System;
using Basics.Shapes;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape a, b;
            Triangle c;
            a = new Square(5);
            b = new Triangle(5, 5, 5);
            c = new Triangle(3, 4, 5);
            Console.WriteLine(a.areaCalculator());
            Console.WriteLine(b.areaCalculator());
            Console.WriteLine(c.areaCalculator(true));
        }
    }
}
