using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Debugging.Models
{
    public class MOBO
    {
        public string name { get; set; }
        public string socket { get; set; }
        public string chipset { get; set; }

        public MOBO(string name, string socket, string chipset)
        {
            this.name = name;
            this.socket = socket;
            this.chipset = chipset;
        }
        public MOBO()
        {

        }
    }
}
