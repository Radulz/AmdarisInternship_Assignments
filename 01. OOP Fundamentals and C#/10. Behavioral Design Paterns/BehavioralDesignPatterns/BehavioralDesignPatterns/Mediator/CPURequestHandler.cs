using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class CPURequestHandler : IRequestHandler<CPURequest>
    {
        public void Handle(CPURequest request)
        {
            Console.WriteLine($"Sending the cpu request message: \"{request.requestmessage}\" ");
        }
    }
}
