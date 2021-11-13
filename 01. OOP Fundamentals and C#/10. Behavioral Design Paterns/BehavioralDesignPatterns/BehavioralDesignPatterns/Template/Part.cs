using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Visitor;

namespace BehavioralDesignPatterns.Template
{
    public abstract class Part : IVisitable
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Part()
        {

        }

        public void Benchmark()
        {
            Console.WriteLine($"Starting the benchmark at {DateTime.Now};");
            Console.WriteLine("The component that is being benchmarked has the following details:");
            Console.WriteLine(GetConcretePartDetails()); 
            Console.WriteLine("Checking the status of the component;");
            Console.WriteLine("Status: OK!");
            Console.WriteLine("Saving the results.");
            Console.WriteLine($"Benchmark process finished at: {DateTime.Now}.");
        }

        public abstract string GetConcretePartDetails();

        public abstract void Accept(IVisitor visitor);
        
    }
}
