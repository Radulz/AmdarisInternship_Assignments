using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class AfterBurnerTesting : BaseDecorator
    {
        public AfterBurnerTesting(ITesting testing) : base(testing)
        {

        }
        public override string TestComponent(Component c)
        {
            return _testsoftware.TestComponent(c) + "and with MSI AfterBurner software ";
        }
    }
}
