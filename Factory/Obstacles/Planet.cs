using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Obstacles
{
    public class Planet : IObstacle
    {
        int _level;
        public Planet(int lvl)
        {
            _level = lvl;
        }
        public void printCharacteristics()
        {
            Console.WriteLine($"PLANET on level: {_level}");
        }
    }
}
