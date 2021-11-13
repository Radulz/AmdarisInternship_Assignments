using BehavioralDesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Template
{
    public class GraphicsProcessingUnit : Part
    {
        public int MemoryCapacity { get; set; }
        public string MemoryType { get; set; }

        public GraphicsProcessingUnit()
        {

        }
        public override string GetConcretePartDetails()
        {
            return $"{this.Make} {this.Model} {this.MemoryCapacity} GB of {this.MemoryType} type memory.";
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
