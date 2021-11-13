using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class GPU : IBenchmark
    {
        public string name { get; set; }
        public string model { get; set; }

        public GPU()
        {

        }

        public void Benchmark()
        {
            Console.WriteLine("Benchmarking the gpu");
        }
    }
}
