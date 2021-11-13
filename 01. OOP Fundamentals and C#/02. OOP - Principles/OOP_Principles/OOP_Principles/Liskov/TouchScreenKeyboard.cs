using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Liskov
{
    public class TouchScreenKeyboard : Keyboard
    {
        public override string getText()
        {
            return "Type a text with you super cool keyboard. (Now we're talking)";
        }
    }
}
