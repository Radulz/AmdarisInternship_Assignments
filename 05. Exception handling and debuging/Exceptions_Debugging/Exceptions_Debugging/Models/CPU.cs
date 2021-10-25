using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Debugging.Models
{
    public class CPU
    {
        public string name { get; set; }
        public string socket { get; set; }
        public double freq { get; set; }

        public List<string> chipsets { get; set; }

        public CPU(string name, string socket, double freq, List<string> chipsets)
        {
            this.name = name;
            this.socket = socket;
            this.freq = freq;
            this.chipsets = chipsets;
        }
        public CPU()
        {

        }
    }
}
