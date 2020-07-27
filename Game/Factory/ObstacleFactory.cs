using Factory.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public abstract class ObstacleFactory
    {
        protected int _level;
        public ObstacleFactory(int level)
        {
            _level = level;
        }
        public IObstacle GetObstacle()
        {
            IObstacle iob = this.Create();
            return iob;
        }
        public abstract IObstacle Create();
    }
}
