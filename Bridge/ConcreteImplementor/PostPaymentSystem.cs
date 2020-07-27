using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // CONCRETE IMPLEMENTOR
    public class PostPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentType)
        {
            Console.WriteLine("Using Post gateway for " + paymentType);
        }
    }
}
