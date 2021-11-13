using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class User : ISubscriber<Component>
    {
        public string Email { get; set; }

        public User(string email)
        {
            this.Email = email;
        }
        public User()
        {

        }
        public void Notify(Component item)
        {
            Console.WriteLine($"{Email} received: The new {item.Make} {item.Model} is out now!");
        }
    }
}
