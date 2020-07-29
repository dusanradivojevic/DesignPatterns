using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Number
    {
        private double value;
        public Number(double num)
        {
            value = num;
        }
        public double GetValue => value;
        public void Cube()
        {
            value *= value * value;
        }
        public void Square()
        {
            value *= value;
        }
        public void SquareRoot()
        {
            value = Math.Sqrt(value);
        }
        public void CubeRoot()
        {
            value = Math.Pow(value, (double)1 / 3);
        }
    }
}
