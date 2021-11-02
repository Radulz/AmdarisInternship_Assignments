using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class GPURequestHandler : IRequestHandler<GPURequest>
    {
        public void Handle(GPURequest request)
        {
            Console.WriteLine($"Sending the gpu request message: \"{request.requestmessage}\" ");
        }
    }
}
