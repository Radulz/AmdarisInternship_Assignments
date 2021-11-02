using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class GPU : Component
    {
        public int MemoryCapacity { get; set; }
        public string MemoryType { get; set; }

        public GPU()
        {

        }

        public override string GetComponentDetails()
        {
            return $"{Make} {Model} gpu with {MemoryCapacity} GB";
        }
    }
}
