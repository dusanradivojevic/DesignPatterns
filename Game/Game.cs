using Factory.Factory;
using Factory.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Game
    {
        int level = 0;
        public void Start()
        {
            Console.WriteLine("In each level of this game, different obstacles will be spawned and shown to the player!\n");
            while(level < 10)
            {
                level++;

                ObstacleFactory factory = new ObstacleManagerFactory().CreateFactory(level);
                IObstacle obstacle = factory.GetObstacle();
                obstacle.printCharacteristics();

                Console.WriteLine("\nPress any key to go to the next level!");
                Console.ReadLine();
            }
        }
    }
}
