using BehavioralDesignPatterns.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor
{
    public class BlenderTesting : IVisitor
    {
        public void Visit(ProcessingUnit cpu)
        {
            Console.WriteLine($"Holding the cpu: {cpu.Make} {cpu.Model} at 100%.");
            Console.WriteLine("Saving the results.");
        }

        public void Visit(GraphicsProcessingUnit gpu)
        {
            Console.WriteLine($"Holding the gpu: {gpu.Model} {gpu.Model} at its maximum power.");
        }
    }
}
