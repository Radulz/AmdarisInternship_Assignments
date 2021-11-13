using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interface_Segregation.Robot
{
    public class DancerRobot : IRobot
    {
        public void dance()
        {
            Console.WriteLine("I can dance");
        }
        public void sing()
        {
            throw new NotImplementedException(); // i can't sing
        }
    }
}
