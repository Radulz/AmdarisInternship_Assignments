using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using InversionOfControl.Models;

namespace InversionOfControl
{
    public class ServiceLocator
    {
        private static readonly IKernel Kernel = new StandardKernel();

        public static void RegisterAll()
        {
            Kernel.Bind<IComponent>().To<CPU>();
            Kernel.Bind<IComponent>().To<GPU>();
            Kernel.Bind<IComponent>().To<RAM>();
        }

        public static IEnumerable<IComponent> ResolveAll()
        {
            return Kernel.GetAll<IComponent>();
        }
    }
}
