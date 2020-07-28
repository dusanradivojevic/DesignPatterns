using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Grizly : IBearBehavior
    {
        public string Eat()
        {
            return "salmon";
        }

        public string GetLatinName()
        {
            return "Ursus arctos horribilis (Grizly bear)";
        }

        public string Inhabit()
        {
            return "North America";
        }
    }
}
