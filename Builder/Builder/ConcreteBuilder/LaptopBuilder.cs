using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder.IBuilder;
using Builder.Builder.Product;

namespace Builder.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        public void AddKeyboard(string type)
        {
            return; // keyboard == null
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public void AddMouse(string type)
        {
            laptop.Mouse = type;
        }

        public void AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}
