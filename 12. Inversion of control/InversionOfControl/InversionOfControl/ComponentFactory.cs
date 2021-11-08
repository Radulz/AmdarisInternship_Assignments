using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    public class ComponentFactory
    {
        private readonly IComponent _component;

        public ComponentFactory(IComponent component)
        {
            _component = component;
        }

        public string GetComponentType()
        {
            return _component.ComponentType();
        }
    }
}
