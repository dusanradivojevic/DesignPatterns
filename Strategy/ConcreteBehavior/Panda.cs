using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Panda : IBearBehavior
    {
        public string Eat()
        {
            return "bambus";
        }

        public string GetLatinName()
        {
            return "Ailuropoda melanoleuca (Giant panda)";
        }

        public string Inhabit()
        {
            return "China";
        }
    }
}
