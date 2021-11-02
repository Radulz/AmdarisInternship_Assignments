using System;
using System.Collections.Generic;
using BehavioralDesignPatterns.Observer;
using BehavioralDesignPatterns.Strategy;
using BehavioralDesignPatterns.Template;
using BehavioralDesignPatterns.Visitor;
using BehavioralDesignPatterns.Mediator;

namespace BehavioralDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer:");
            TestObserver();
            Console.WriteLine();
            Console.WriteLine("Strategy:");
            TestStrategy();
            Console.WriteLine();
            Console.WriteLine("Template:");
            TestTemplate();
            Console.WriteLine();
            Console.WriteLine("Visitor:");
            TestVisitor();
            Console.WriteLine();
            Console.WriteLine("Mediator:");
            TestMediator();
        }

        public static void TestObserver()
        {
            var notification = new Notification();
            User u1, u2, u3;
            u1 = new User { Email = "user1@gmail.com" };
            u2 = new User { Email = "user2@yahoo.com" };
            u3 = new User { Email = "user3@yahoo.ro" };

            notification.AddSubscriber(u1);
            notification.AddSubscriber(u2);

            CPU c1 = new CPU { Make = "Intel", Model = "i5-11600k", Cores = 6, Frequency = 5.0 };
            GPU g1 = new GPU { Make = "Nvidia", Model = "RTX3090", MemoryCapacity = 8, MemoryType = "GDDR6X" };

            notification.SendNotification(c1);
            notification.SendNotification(g1);
        }

        public static void TestStrategy()
        {
            CPU c1 = new CPU { Make = "Intel", Model = "i5-11600k", Cores = 6, Frequency = 5.0 };
            GPU g1 = new GPU { Make = "Nvidia", Model = "RTX3090", MemoryCapacity = 8, MemoryType = "GDDR6X" };
            BenchmarkService s = new BenchmarkService(c1);
            s.Benchmark();
            s.component = g1;
            Console.WriteLine();
            s.Benchmark();
        }

        public static void TestTemplate()
        {
            ProcessingUnit p1 = new ProcessingUnit { Make = "AMD", Model = "Ryzen 7 5800X", Cores = 6, Frequency = 4.50 };
            GraphicsProcessingUnit p2 = new GraphicsProcessingUnit { Make = "AMD", Model = "RX6800XT", MemoryCapacity = 6, MemoryType = "GDDR6X" };
            p1.Benchmark();
            Console.WriteLine();
            p2.Benchmark();
        }

        public static void TestVisitor()
        {
            var parts = new List<IVisitable>
            {
                new ProcessingUnit { Make = "AMD", Model = "Ryzen 7 5800X", Cores = 6, Frequency = 4.50 },
                new GraphicsProcessingUnit { Make = "AMD", Model = "RX6800XT", MemoryCapacity = 6, MemoryType = "GDDR6X" },
                new ProcessingUnit { Make = "Intel", Model = "i5-11600k", Cores = 6, Frequency = 5.0 },
                new GraphicsProcessingUnit { Make = "Nvidia", Model = "RTX3090", MemoryCapacity = 8, MemoryType = "GDDR6X" },
            };

            IVisitor visitor = new BlenderTesting();
            parts.ForEach(x => x.Accept(visitor));
        }

        public static void TestMediator()
        {
            var mediator = new RequestMediator();
            CPU c1 = new CPU { Make = "Intel", Model = "i5-11600k", Cores = 6, Frequency = 5.0 };
            GPU g1 = new GPU { Make = "Nvidia", Model = "RTX3090", MemoryCapacity = 8, MemoryType = "GDDR6X" };

            CPURequest cr1 = new CPURequest(c1);
            GPURequest gr1 = new GPURequest(g1);
            CPURequestHandler crh1 = new();
            GPURequestHandler grh1 = new();

            mediator.RegisterHandler(typeof(CPURequest), crh1);
            mediator.RegisterHandler(typeof(GPURequest), grh1);

            mediator.SendRequestHandler(cr1);
            mediator.SendRequestHandler(gr1);

        }
    }
}
