using Factory.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class AsteroidFactory : ObstacleFactory
    {
        public AsteroidFactory(int level) : base(level)
        {

        }
        public override IObstacle Create()
        {
            Asteroid asteroid = new Asteroid(_level); //_level from obstacleFactory
            return asteroid;
        }
    }
}
