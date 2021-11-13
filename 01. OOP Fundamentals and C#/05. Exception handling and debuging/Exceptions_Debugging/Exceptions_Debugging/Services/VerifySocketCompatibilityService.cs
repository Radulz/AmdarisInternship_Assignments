using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions_Debugging.Models;
using Exceptions_Debugging.Exceptions;

namespace Exceptions_Debugging.Services
{
    public static class VerifySocketCompatibilityService
    {
        public static bool verifySocket(CPU c, MOBO b)
        {
            if(c.socket != b.socket)
            {
                throw new SocketIncompatibility(b.name + " motherboard does not support " + c.name + " cpu with this socket");
            }
            return true;
        }
    }
}
