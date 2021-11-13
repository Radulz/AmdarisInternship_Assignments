using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Exceptions_Debugging.Exceptions
{
    [Serializable]
    internal class UnsupportedChipset : Exception
    {
        public UnsupportedChipset()
        {

        }

        public UnsupportedChipset(string message) : base(message)
        {

        }

        public UnsupportedChipset(string message, Exception inner) : base(message, inner)
        {

        }

        protected UnsupportedChipset(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
