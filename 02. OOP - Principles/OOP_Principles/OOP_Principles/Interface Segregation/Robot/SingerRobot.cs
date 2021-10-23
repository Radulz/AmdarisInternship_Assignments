using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interface_Segregation.Robot
{
    public class SingerRobot : IRobot
    {
        public void dance()
        {
            throw new NotImplementedException(); // i can't dance
        }

        public void sing()
        {
            Console.WriteLine("Singing...");
        }
        // the dance method will stop the execution of the program
        // we can apply Interface segregation principle to solve this problem
    }
}
