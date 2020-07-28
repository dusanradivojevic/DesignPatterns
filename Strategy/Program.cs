using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear panda = new Bear(new Panda());
            panda.GetDetails();

            Bear grizly = new Bear(new Grizly());
            grizly.GetDetails();

            Console.ReadLine();
        }
    }
}
