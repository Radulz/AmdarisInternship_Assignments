using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Liskov
{
    public class Keyboard
    {
        public virtual string getText()
        {
            return "Type a text";
        }
    }
}
