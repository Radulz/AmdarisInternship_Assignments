using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.SingleResponsibility_DependencyInversion
{
    public class Component
    {
        private int id; // unique identifier
        private string name { get; set; }
        private int price { get; set; }
        private static int cnt = 0;

        public Component(string name, int price)
        {
            cnt++;
            this.id = cnt;
            this.name = name;
            this.price = price;
        }
        public Component()
        {
            cnt++;
            this.id = cnt;
        }
        public bool verifyPrice(int price) // Single responsibility principle violated
        {
            if(this.price <= price)
            {
                return true;
            }
            return false;
        }
    }
}
