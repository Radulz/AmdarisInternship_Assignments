using StructuralDesignPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public class ComponentRepositoryProxy : IComponentRepository
    {
        private ThirdPartyComponentRepository _componentsrepo;
        public User user { get; set; }

        public ComponentRepositoryProxy(User u)
        {
            _componentsrepo = new ThirdPartyComponentRepository();
            user = u;
        }
        public void AddComponent(Component c)
        {
            if (HasPermission())
            {
                _componentsrepo.AddComponent(c);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public List<Component> GetAllComponents()
        {
            if (HasPermission())
            {
                return _componentsrepo.GetAllComponents();
            }
            else
            {
                throw new UnauthorizedAccessException();
            } 
        }

        public Component GetComponent(Component c)
        {
            if (HasPermission())
            {
                return _componentsrepo.GetComponent(c);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
            
        }

        public void RemoveComponent(Component c)
        {
            if (HasPermission())
            {
               _componentsrepo.RemoveComponent(c);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
            
        }

        public void UpdateComponent(Component c)
        {
            if (HasPermission())
            {
                var index = GetAllComponents().FindIndex(x => x.Id == c.Id);
                if (index != -1)
                {
                    GetAllComponents()[index] = c;
                }
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public bool HasPermission()
        {
            return user.Admin;
        }
    }
}
