using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class Archer : IWarrior
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a arrow, causing 55 damage!");
        }
    }
}
