using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator
{
    public abstract class BaseDecorator : ITesting
    {
        protected ITesting _testsoftware;
        public BaseDecorator(ITesting testing)
        {
            _testsoftware = testing;
        }
        public abstract string TestComponent(Component c);
        
    }
}
