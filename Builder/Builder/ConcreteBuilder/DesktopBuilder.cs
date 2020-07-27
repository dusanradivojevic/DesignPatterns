using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder.IBuilder;
using Builder.Builder.Product;

namespace Builder.Builder.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }

        public void AddKeyboard(string type)
        {
            desktop.Keyboard = type;
        }

        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }

        public void AddMouse(string type)
        {
            desktop.Mouse = type;
        }

        public void AddTouchScreen(string enabled)
        {
            return;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
