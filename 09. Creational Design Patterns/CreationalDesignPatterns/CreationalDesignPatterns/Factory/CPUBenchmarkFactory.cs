using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class CPUBenchmarkFactory : IBenchmarkFactory
    {
        public IBenchmark CreateBenchmark(string Name, string Model)
        {
            return new CPU
            {
                name = Name,
                model = Model,
            };
        }
    }
}
