using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator
{
    public class RequestMediator
    {
        private Dictionary<Type, object> _requestDictionary;

        public RequestMediator()
        {
            _requestDictionary = new Dictionary<Type, object>();
        }

        public void RegisterHandler<T>(Type type, IRequestHandler<T> handler) where T : IRequest
        {
            _requestDictionary[type] = handler;
        }

        public void RemoveHandler(Type type)
        {
            _requestDictionary.Remove(type);
        }

        public void SendRequestHandler<T>(T request) where T : IRequest
        {
            var h = _requestDictionary[request.GetType()] as IRequestHandler<T>;
            h.Handle(request);
        }
    }
}
