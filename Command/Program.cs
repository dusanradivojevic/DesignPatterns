using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Number five = new Number(5);
            Calculator calculator = new Calculator(new SquareCommand(five), new CubeCommand(five));

            calculator.Cube();
            Console.WriteLine($"Value: {five.GetValue}");

            calculator.CubeRoot();
            Console.WriteLine($"Value: {five.GetValue}");

            Console.ReadLine();
        }
    }
}
