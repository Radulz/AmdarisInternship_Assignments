using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.SingleResponsibility_DependencyInversion
{
    public class ComponentRefactored
    {
        public int id { get; }// unique identifier
        public string name { get; set; }
        public int price { get; set; }
        private static int cnt = 0;

        public ComponentRefactored(string name, int price)
        {
            cnt++;
            id = cnt;
            this.name = name;
            this.price = price;
        }

        public ComponentRefactored()
        {
            cnt++;
            id = cnt;
        }
        public bool verifyPrice(int price)
        {
            VerifyPriceService s = new VerifyPriceService(); //violates Dependency Inversion principle
            bool result= s.verifyPrice(this.price, price);
            return result;
        }
        public bool verifyPriceRefactored(int price, IVerifyPrice service)
        {
            bool result = service.verifyPrice(this.price, price);
            return result;
        }
    }
}
