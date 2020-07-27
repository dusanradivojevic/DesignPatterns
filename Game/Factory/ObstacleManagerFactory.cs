using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class ObstacleManagerFactory
    {
        public ObstacleFactory CreateFactory(int level)
        {
            ObstacleFactory returnValue = null;
            if (level % 2 == 0)
            {
                returnValue = new PlanetFactory(level);
            }
            else
            {
                returnValue = new AsteroidFactory(level);
            }
            return returnValue;
        }
    }
}
