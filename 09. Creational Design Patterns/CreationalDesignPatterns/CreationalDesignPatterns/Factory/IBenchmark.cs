using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public interface IBenchmark
    {
        string name { get; set; }
        void Benchmark();
    }
}
