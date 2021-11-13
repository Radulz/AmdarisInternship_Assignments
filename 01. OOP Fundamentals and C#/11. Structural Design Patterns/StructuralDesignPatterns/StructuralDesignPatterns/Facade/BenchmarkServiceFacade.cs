using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade
{
    public class BenchmarkServiceFacade
    {
        public void HWInfoorMSIAfterBurnerTesting(Component c)
        {
            ComplexBenchmarkingService service = new ComplexBenchmarkingService(c);
            if(c.ComponentType == "cpu")
            {
                service.Init();
                service.Validation();
                service.TestCpuWithHWInfo();
            }
            else if(c.ComponentType == "gpu")
            {
                service.Init();
                service.Validation();
                service.TestGpuWithMSIAfterBurner();
            }
            else
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            
        }
    }
}
