using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class MeleeWarrior : IWarrior
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a sword, causing 100 damage!");
        }
    }
}
