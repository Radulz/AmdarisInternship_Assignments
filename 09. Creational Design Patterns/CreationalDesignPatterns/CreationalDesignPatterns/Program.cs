using System;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton();
            Console.WriteLine();
            Console.WriteLine();
            TestFactory();
        }

        public static void TestSingleton()
        {
            var d1 = ComponentDatabase.Database;
            var c1 = new Component
            {
                name = "Intel",
                type = "CPU",
                details = "I7-10770K",
            };
            var c2 = new Component
            {
                name = "AMD",
                type = "CPU",
                details = "Ryzen 5 5600X",
            };

            d1.Components.Add(c1);

            var d2 = ComponentDatabase.Database;

            d2.Components.Add(c2);

            foreach (Component c in d1.Components)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(d1 == d2);
        }

        public static void TestFactory()
        {
            IBenchmarkFactory cpufactory = new CPUBenchmarkFactory();
            IBenchmarkFactory gpufactory = new GPUBenchmarkFactory();

            IBenchmark cpu = cpufactory.CreateBenchmark("Intel", "i7");
            IBenchmark gpu = gpufactory.CreateBenchmark("AMD", "RX6000XT");

            cpu.Benchmark();
            gpu.Benchmark();

        }
    }
}
