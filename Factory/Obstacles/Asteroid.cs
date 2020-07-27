using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Obstacles
{
    public class Asteroid : IObstacle
    {
        int _level;
        public Asteroid(int lvl)
        {
            _level = lvl;
        }
        public void printCharacteristics()
        {
            Console.WriteLine($"ASTEROID on level: {_level}");
        }
    }
}
