using System;
using System.Collections.Generic;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.RegisterAll();

            IEnumerable<IComponent> components = ServiceLocator.ResolveAll();

            foreach (var item in components)
            {
                ComponentFactory comp = new ComponentFactory(item);
                Console.WriteLine(comp.GetComponentType());
            }

        }
    }
}
