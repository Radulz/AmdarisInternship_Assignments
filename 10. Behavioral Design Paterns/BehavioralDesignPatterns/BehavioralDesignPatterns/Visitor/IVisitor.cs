using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Template;

namespace BehavioralDesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(ProcessingUnit cpu);
        void Visit(GraphicsProcessingUnit gpu);
    }
}
