using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Mercedes();
            CarDecorator decorator = new DiscountedPrice(car);

            Console.WriteLine($"Made: {decorator.Make} Price: {decorator.GetPrice()} " +
                $"DiscountedPrice: {decorator.GetDiscountedPrice()}");

            Console.ReadLine();
        }
    }
}
