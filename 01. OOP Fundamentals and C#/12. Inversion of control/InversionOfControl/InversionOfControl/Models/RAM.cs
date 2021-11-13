using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Models
{
    public class RAM : Component
    {
        public int Capacity { get; set; }
        public RAM() : base()
        {

        }
        public override string ComponentType()
        {
            return "This is a random access memory stick.";
        }
    }
}
