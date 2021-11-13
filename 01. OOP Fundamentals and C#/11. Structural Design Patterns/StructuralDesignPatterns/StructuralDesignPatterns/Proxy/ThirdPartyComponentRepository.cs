using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    public class ThirdPartyComponentRepository : IComponentRepository
    {
        private List<Component> _components;

        public ThirdPartyComponentRepository()
        {
            _components = new List<Component>();
        }
        public void AddComponent(Component c)
        {
            _components.Add(c);
        }

        public List<Component> GetAllComponents()
        {
            return _components;
        }

        public Component GetComponent(Component c)
        {
            var comp = _components.First(x => x.Id == c.Id);
            if (comp is null)
            {
                throw new ArgumentNullException();
            }
            return comp;
        }

        public void RemoveComponent(Component c)
        {
            _components.Remove(c);
        }

        public void UpdateComponent(Component c)
        {
            var index = _components.FindIndex(x => x.Id == c.Id);
            if (index != -1)
            {
                _components[index] = c;
            }
        }
        
    }
}
