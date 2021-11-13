using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class GPUBenchmarkFactory : IBenchmarkFactory
    {
        public IBenchmark CreateBenchmark(string Name, string Model)
        {
            return new GPU
            {
                name = Name,
                model = Model,
            };
        }
    }
}
