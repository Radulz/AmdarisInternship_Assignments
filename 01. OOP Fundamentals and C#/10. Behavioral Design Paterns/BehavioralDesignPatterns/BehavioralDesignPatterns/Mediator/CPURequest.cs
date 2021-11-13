using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Observer;

namespace BehavioralDesignPatterns.Mediator
{
    public class CPURequest : IRequest
    {
        public CPU cpu { get; set; }
        public string requestmessage { get; }
        public CPURequest()
        {

        }
        public CPURequest(CPU c)
        {
            this.cpu = c;
            requestmessage = $"Requesting {cpu.Make} {cpu.Model} processing unit.";
        }

    }
}
