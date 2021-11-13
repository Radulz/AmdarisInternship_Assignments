using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class CPU : IBenchmark
    {
        public string name { get; set; }
        public string model { get; set; }

        public CPU()
        {

        }
        public void Benchmark()
        {
            Console.WriteLine("Benchmarking the cpu");
        }
    }
}
