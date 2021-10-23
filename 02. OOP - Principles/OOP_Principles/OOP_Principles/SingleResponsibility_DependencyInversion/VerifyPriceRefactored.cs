using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.SingleResponsibility_DependencyInversion
{
    public class VerifyPriceRefactored : IVerifyPrice
    {
        public bool verifyPrice(int p, int price)
        {
            return (p <= price);
        }
    }
}
