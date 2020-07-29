using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Calculator
    {
        ICommand squareCommand;
        ICommand cubeCommand;
        public Calculator(ICommand square, ICommand cube)
        {
            this.squareCommand = square;
            this.cubeCommand = cube;
        }
        public void Cube()
        {
            cubeCommand.Execute();
        }
        public void CubeRoot()
        {
            cubeCommand.Unexecute();
        }
        public void Square()
        {
            squareCommand.Execute();
        }
        public void SquareRoot()
        {
            squareCommand.Unexecute();
        }
    }
}
