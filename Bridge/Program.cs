using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment(); // customer decision
            order._IPaymentSystem = new KombankPaymentSystem();
            order.MakePayment();

            Console.ReadLine();
        }
    }
}
