using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.ConnectionRefactored
{
    public class Device
    {
        public string name { get; set; }
        public Device(string name)
        {
            this.name = name;
        }
    }
}
