using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Models
{
    public class CPU : Component
    {
        public int Cores { get; set; }
        public CPU() : base()
        {

        }
        public override string ComponentType()
        {

            return "This is a central processing unit.";
        }
    }
}
