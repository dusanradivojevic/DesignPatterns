using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public sealed class Hyundai : ICar
    {
        public string Make => "Tucson";

        public double GetPrice()
        {
            return 44000;
        }
    }
}
