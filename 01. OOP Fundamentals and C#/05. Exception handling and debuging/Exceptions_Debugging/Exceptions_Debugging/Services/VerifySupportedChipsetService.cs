using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions_Debugging.Models;
using Exceptions_Debugging.Exceptions;

namespace Exceptions_Debugging.Services
{
    public static class VerifySupportedChipsetService
    {
        public static bool chipsetCompatibility(CPU c, MOBO b)
        {
            bool sw = false;
            foreach(string s in c.chipsets)
            {
                if(s == b.chipset)
                {
                    sw = true;
                    return sw;
                }
            }
            throw new UnsupportedChipset(b.name + " does not work with any of cpu " + c.name + " compatible chipsets");
        }
    }
}
