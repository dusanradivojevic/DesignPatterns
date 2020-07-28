using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PolarBear : IBearBehavior
    {
        public string Eat()
        {
            return "seals";
        }

        public string GetLatinName()
        {
            return "Ursus maritimus (Polar bear)";
        }

        public string Inhabit()
        {
            return "Arctic";
        }
    }
}
