using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RefinedAbstraction
{
    // REFINED ABSTRACTION
    public class CashPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Cash Payment.");
        }
    }
}
