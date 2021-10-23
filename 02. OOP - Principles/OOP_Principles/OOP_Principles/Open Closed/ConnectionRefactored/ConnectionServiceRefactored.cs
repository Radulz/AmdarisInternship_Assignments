using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.ConnectionRefactored
{
    public class ConnectionServiceRefactored
    {
        public string isConnected(Device d)
        {
            return "Device: " + d.name + " is connected";
        }
        
    }
}
