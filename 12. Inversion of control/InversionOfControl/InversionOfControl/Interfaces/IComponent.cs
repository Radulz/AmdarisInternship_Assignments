using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InversionOfControl.Models;

namespace InversionOfControl
{
    public interface IComponent
    {
        public string ComponentType();
    }
}
