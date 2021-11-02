using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.Observer;
namespace BehavioralDesignPatterns.Mediator
{
    public class GPURequest : IRequest
    {
        public GPU gpu { get; set; }
        public string requestmessage { get; }
        public GPURequest()
        {

        }
        public GPURequest(GPU g)
        {
            this.gpu = g;
            requestmessage = $"Requesting {gpu.Make} {gpu.Model} graphics unit.";
        }
    }
}
