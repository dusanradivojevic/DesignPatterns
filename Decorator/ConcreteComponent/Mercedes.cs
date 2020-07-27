using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public sealed class Mercedes : ICar
    {
        public string Make => "G Class";

        public double GetPrice()
        {
            return 120000;
        }
    }
}
