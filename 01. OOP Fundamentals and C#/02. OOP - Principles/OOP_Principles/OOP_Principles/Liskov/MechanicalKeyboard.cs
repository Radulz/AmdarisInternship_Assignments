using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Liskov
{
    public class MechanicalKeyboard : Keyboard
    {
        public override string getText()
        {
            return "Type a text with you cool special keyboard";
        }
    }
}
