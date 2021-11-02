using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class CPU : Component
    {
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public CPU()
        {

        }

        public override string GetComponentDetails()
        {
            return $"{this.Make} {this.Model} cpu, with {this.Cores} cores, running at {this.Frequency} GHz";
        }
    }
}
