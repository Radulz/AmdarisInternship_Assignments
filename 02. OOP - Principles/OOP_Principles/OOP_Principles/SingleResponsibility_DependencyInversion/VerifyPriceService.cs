using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.SingleResponsibility_DependencyInversion
{
    class VerifyPriceService : IVerifyPrice
    {
        public bool verifyPrice(int p, int price)
        {
            if(p <= price)
            {
                return true;
            }
            return false;
        }    
    }
}
