using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Exceptions_Debugging.Exceptions
{
    [Serializable]
    internal class SocketIncompatibility : Exception
    {
        public SocketIncompatibility()
        {

        }

        public SocketIncompatibility(string message) : base(message)
        {

        }

        public SocketIncompatibility(string message, Exception inner) : base(message, inner)
        {

        }

        protected SocketIncompatibility(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
