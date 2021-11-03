using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public class HWInfoTestingSoftware : BaseDecorator
    {
        public HWInfoTestingSoftware(ITesting testing) : base(testing)
        {

        }
        public override string TestComponent(Component c)
        {
            return _testsoftware.TestComponent(c) + "with HWInfo64 software ";
        }
    }
}
