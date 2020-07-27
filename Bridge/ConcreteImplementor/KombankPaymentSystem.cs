using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // CONCRETE IMPLEMENTOR
    public class KombankPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentType)
        {
            Console.WriteLine("Using Kombank gateway for " + paymentType);
        }
    }
}
