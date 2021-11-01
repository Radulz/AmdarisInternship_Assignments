using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public interface IBenchmarkFactory
    {
        IBenchmark CreateBenchmark(string Name, string Model);
    }
}
