using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Mogli smo napraviti i interfejs za svako ponasanje. 
    // Pa bismo na primer imali IEat i IInhabit, za koje bismo imali
    // Carnivors & Herbivore kao implementore i sa druge strane na primer
    // Polar & Forest, koje bismo dalje kombinovali za svaku vrstu medveda.
    public interface IBearBehavior
    {
        string GetLatinName();
        string Eat();
        string Inhabit();
    }
}
