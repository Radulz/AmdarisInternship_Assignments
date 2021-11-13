using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public interface IRequestHandler<T> where T : IRequest
    {
        void Handle(T request);
    }
}
