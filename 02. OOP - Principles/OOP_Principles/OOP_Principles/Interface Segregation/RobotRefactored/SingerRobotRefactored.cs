using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Interface_Segregation.RobotRefactored
{
    public class SingerRobotRefactored : ISing
    {
        public void sing()
        {
            Console.WriteLine("singing...");
        }
    }
}
