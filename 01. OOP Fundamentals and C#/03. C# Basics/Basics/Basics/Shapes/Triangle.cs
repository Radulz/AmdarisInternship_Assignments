using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Basics.Shapes
{
    class Triangle : Shape
    {
        public double l1 { get; set; }
        public double l2 { get; set; }
        public double l3 { get; set; }
        public Triangle(double l1, double l2, double l3) : base("Triangle")
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }
        public override double areaCalculator()
        {
            double sp = perimeterCalculator() / 2;
            return Sqrt(sp * (sp - l1) * (sp - l2) * (sp - l3));
        }
        public double areaCalculator(bool rtriangle) //overloaded method
        {
            if(rtriangle == true)
            {
                double c1, c2, ip, s1, s2, s3;
                double area = 1;
                c1 = l1 * l1;
                c2 = l2 * l2;
                ip = l3 * l3;
                s1 = c1 + c2;
                s2 = c1 + ip;
                s3 = c2 + ip;
                if(s1 == ip)
                {
                    area = l1 * l2 / 2;
                }
                else if(s2 == c2)
                {
                    area = l1 * l3 / 2;
                }
                else if(s3 == c1)
                {
                    area = l2 * l3 / 2;
                }
                return area;
            }
            return areaCalculator();
        }

        public override double perimeterCalculator()
        {
            return l1 + l2 + l3;
        }
    }
}
