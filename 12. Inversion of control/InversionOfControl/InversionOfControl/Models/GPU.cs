using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Models
{
    public class GPU : Component
    {
        public string Fans { get; set; }
        public GPU() : base()
        {

        }
        public override string ComponentType()
        {
            return "This is a graphical processing unit.";
        }
    }
}
