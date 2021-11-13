using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade
{
    public class ComplexBenchmarkingService
    {
        public Component component { get; set; }
        public ComplexBenchmarkingService(Component c)
        {
            this.component = c;
        }

        public void Init()
        {
            Console.WriteLine("Preparing the environment for the benchmark.");
        }
        public void Validation()
        {
            Console.WriteLine("Checking the component working status.");
            if(component.ComponentType == "cpu")
            {
                Console.WriteLine($"The CPU {component.Make} {component.Model} is ready for the tests.");
            }
            else if(component.ComponentType == "gpu")
            {
                Console.WriteLine($"The GPU {component.Make} {component.Model} is ready for the benchmark.");
            }
            else
            {
                Console.WriteLine("Unrecognised component type, aborting the benchmark...");
            }
        }
        public void TestCpuWithHWInfo()
        {
            if(component.ComponentType != "cpu")
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            else
            {
                Console.WriteLine($"Testing the {component.Make} {component.Model} cpu with HWInfo64...");
                Console.WriteLine($"Savind the results... {DateTime.Now}");
            }  
        }

        public void TestCpuWithAIDA()
        {
            if (component.ComponentType != "cpu")
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            else
            {
                Console.WriteLine($"Testing the {component.Make} {component.Model} cpu with AIDA64...");
                Console.WriteLine($"Savind the results... {DateTime.Now}");
            }
        }

        public void TestGpuWithMSIAfterBurner()
        {
            if (component.ComponentType != "gpu")
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            else
            {
                Console.WriteLine($"Testing the {component.Make} {component.Model} cpu with MSI After Burner...");
                Console.WriteLine($"Savind the results... {DateTime.Now}");
            }
        }

        public void TestCpuWithCineBench()
        {
            if (component.ComponentType != "cpu")
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            else
            {
                Console.WriteLine($"Testing the {component.Make} {component.Model} cpu with CineBench...");
                Console.WriteLine($"Savind the results... {DateTime.Now}");
            }
        }

        public void TestGpuWithPassMark()
        {
            if (component.ComponentType != "gpu")
            {
                Console.WriteLine("Cannot test this type of component.");
            }
            else
            {
                Console.WriteLine($"Testing the {component.Make} {component.Model} cpu with PassMark...");
                Console.WriteLine($"Savind the results... {DateTime.Now}");
            }
        }
    }
}
