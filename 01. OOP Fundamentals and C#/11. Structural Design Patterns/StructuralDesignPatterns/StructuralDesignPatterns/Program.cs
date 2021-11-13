using System;
using StructuralDesignPatterns.Facade;
using StructuralDesignPatterns.Decorator;

namespace StructuralDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy:");
            TestProxy();
            Console.WriteLine();
            Console.WriteLine("Facade:");
            TestFacade();
            Console.WriteLine();
            Console.WriteLine("Decorator:");
            TestDecorator();
        }

        public static void TestProxy()
        {
            User user = new User { Name = "user1", Email = "useri1@gmail.com", Admin = true };
            User user1 = new User { Name = "user2", Email = "User@gmail.com", Admin = false };
            var componentproxy = new ComponentRepositoryProxy(user);
            Component c1, c2;
            c1 = new Component
            {
                Make = "Intel",
                Model = "i7",
                ComponentType = "cpu",
                Id = new Guid(),
            };

            c2 = new Component
            {
                Make = "AMD",
                Model = "Ryzen 5",
                ComponentType = "cpu",
                Id = new Guid(),
            };
            componentproxy.AddComponent(c1);
            componentproxy.AddComponent(c2);
            var comps = componentproxy.GetAllComponents();
            comps.ForEach(x => Console.WriteLine($"{x.Make} {x.Model} {x.ComponentType}"));
            componentproxy.RemoveComponent(c1);
            Console.WriteLine();
            comps.ForEach(x => Console.WriteLine($"{x.Make} {x.Model} {x.ComponentType}"));
            //componentproxy.user = user1;
            //componentproxy.RemoveComponent(c2); this throws an exception
        }

        public static void TestFacade()
        {
            var service = new BenchmarkServiceFacade();
            var c1 = new Component
            {
                Make = "Intel",
                Model = "i7",
                ComponentType = "cpu",
                Id = new Guid(),
            };

            var g2 = new Component
            {
                Make = "AMD",
                Model = "RX4800XT",
                ComponentType = "gpu",
                Id = new Guid(),
            };
            service.HWInfoorMSIAfterBurnerTesting(c1);
            Console.WriteLine();
            service.HWInfoorMSIAfterBurnerTesting(g2);
        }

        public static void TestDecorator()
        {
            var c1 = new Component
            {
                Make = "Intel",
                Model = "i7",
                ComponentType = "cpu",
                Id = new Guid(),
            };

            var g2 = new Component
            {
                Make = "AMD",
                Model = "RX4800XT",
                ComponentType = "gpu",
                Id = new Guid(),
            };
            ITesting testingsoftware = new SimpleTestingSoftware();
            testingsoftware = new HWInfoTestingSoftware(testingsoftware);
            testingsoftware = new AfterBurnerTesting(testingsoftware);

            Console.WriteLine(testingsoftware.TestComponent(c1));
        }
    }
}
