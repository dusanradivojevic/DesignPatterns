using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SquareCommand : ICommand
    {
        private Number number;
        public SquareCommand(Number number)
        {
            this.number = number;
        }

        public void Execute()
        {
            number.Square();
        }

        public void Unexecute()
        {
            number.SquareRoot();
        }
    }
}
