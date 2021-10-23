using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.ConnectionRefactored
{
    public class Mouse : Device
    {
        public int maxDPI { get; set; }
        public Mouse(string name, int dpi) : base(name)
        {
            this.maxDPI = dpi;
        }
    }
}
