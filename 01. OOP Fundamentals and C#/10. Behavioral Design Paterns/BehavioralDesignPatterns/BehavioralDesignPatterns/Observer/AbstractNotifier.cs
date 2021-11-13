using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public abstract class AbstractNotifier<T>
    {
        private List<ISubscriber<T>> _subs;

        public AbstractNotifier()
        {
            _subs = new List<ISubscriber<T>>();
        }

        public void AddSubscriber(ISubscriber<T> user)
        {
            _subs.Add(user);
        }

        public void SendNotification(T item)
        {
            _subs.ForEach(s => s.Notify(item));
        }
    }
}
