using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CubeCommand : ICommand
    {
        private Number number;
        public CubeCommand(Number number)
        {
            this.number = number;
        }
        public void Execute()
        {
            number.Cube();
        }

        public void Unexecute()
        {
            number.CubeRoot();
        }
    }
}
