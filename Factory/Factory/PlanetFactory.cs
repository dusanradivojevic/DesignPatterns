using Factory.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class PlanetFactory : ObstacleFactory
    {
        public PlanetFactory(int level) : base(level)
        {

        }
        public override IObstacle Create()
        {
            Planet planet = new Planet(_level);
            return planet;
        }
    }
}
