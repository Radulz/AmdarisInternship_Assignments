using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Observer;

namespace BehavioralDesignPatterns.Strategy
{
    public class BenchmarkService
    {
        public Component component { get; set; }
        public BenchmarkService(Component component)
        {
            this.component = component;
        }

        public void Benchmark()
        {
            Console.WriteLine("Starting the benchmark for: ");
            Console.WriteLine(component.GetComponentDetails());
            Console.WriteLine("Benchmark finished successfully.");
        }
    }
}
