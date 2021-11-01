using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class Component
    {
        public string name { get; set; }
        public string type { get; set; }
        public string details { get; set; }

        public Component()
        {

        }

        public override string ToString()
        {
            return $"{type}, {name}, {details}";
        }
    }
}
