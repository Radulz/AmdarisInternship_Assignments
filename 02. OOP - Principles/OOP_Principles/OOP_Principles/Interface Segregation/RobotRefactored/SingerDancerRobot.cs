using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interface_Segregation.RobotRefactored
{
    public class SingerDancerRobot : IDance, ISing
    {
        public void dance()
        {
            Console.WriteLine("dancing...");
        }

        public void sing()
        {
            Console.WriteLine("and singing..."); // each robot can implement which interface is suitable for it.
        }
    }
}
