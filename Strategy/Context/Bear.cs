using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Bear
    {
        IBearBehavior ibb;
        public Bear(IBearBehavior ibb)
        {
            this.ibb = ibb;
        }
        public void GetDetails()
        {
            Console.WriteLine($"\nName: {ibb.GetLatinName()}\nEats: {ibb.Eat()}, Inhabits: {ibb.Inhabit()}");
        }
    }
}
