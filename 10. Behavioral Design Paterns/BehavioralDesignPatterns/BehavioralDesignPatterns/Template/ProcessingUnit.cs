using BehavioralDesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Template
{
    public class ProcessingUnit : Part
    {
        public double Frequency { get; set; }
        public int Cores { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string GetConcretePartDetails()
        {
            return $"{this.Make} {this.Model} with {this.Cores} cores, running at {this.Frequency} GHz";
        }
    }
}
