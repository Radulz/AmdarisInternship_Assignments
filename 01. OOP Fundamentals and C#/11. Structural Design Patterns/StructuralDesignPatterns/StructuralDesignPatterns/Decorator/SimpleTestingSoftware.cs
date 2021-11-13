using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class SimpleTestingSoftware : ITesting
    {
        public string TestComponent(Component c)
        {
           return $"Testing the {c.ComponentType} {c.Make} {c.Model} ";
        }
    }
}
