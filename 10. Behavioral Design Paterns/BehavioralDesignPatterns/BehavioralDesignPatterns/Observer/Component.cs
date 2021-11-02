using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public abstract class Component
    {
        public string Make { get; set; }
        public string Model { get; set; }
        //strategy design pattern
        public abstract string GetComponentDetails();
    }
}
