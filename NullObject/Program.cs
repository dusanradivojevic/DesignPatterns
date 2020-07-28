using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWarrior war;
            string input = "";
            while(!input.Equals("0"))
            {
                Console.WriteLine("\nChoose your warrior:\nSwordsman -> 1\nArcher -> 2\n\n" +
                    "To exit the game press 0.");
                input = Console.ReadLine();

                switch(input)
                {
                    case "0": war = new NullWarrior(); break;
                    case "1": war = new MeleeWarrior(); break;
                    case "2": war = new Archer(); break;
                    default: war = new NullWarrior(); break;
                }

                war.Attack();
            }

            Console.WriteLine("Game is finished.");
            Console.ReadLine();
        }
    }
}
