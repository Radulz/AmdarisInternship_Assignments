using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public interface IComponentRepository 
    {
        public void AddComponent(Component c);

        public void RemoveComponent(Component c);
        public Component GetComponent(Component c);

        public List<Component> GetAllComponents();
        public void UpdateComponent(Component c);
    }
}
