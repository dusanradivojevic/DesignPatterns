using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder.Product;

namespace Builder.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        // it should build a product step by step and return result when finished
        void AddMemory(string memory);
        void AddDrive(string size);

        void AddKeyboard(string type);
        void AddMouse(string type);

        void AddTouchScreen(string enabled);
        ComputerSystem GetSystem();
    }
}
