using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Models
{
    abstract public class Component : IComponent
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Component()
        {

        }
        public abstract string ComponentType();
        
    }
}
