using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder.IBuilder;

namespace Builder.Builder.Director
{
        //dictates the building way of product 
    public class ConfigurationBuilder
    {
        // collection received from the frontend
        public void BuildSystem(ISystemBuilder systemBuilder, NameValueCollection collection)
        {
            systemBuilder.AddDrive(collection["Drive"]);
            systemBuilder.AddMemory(collection["RAM"]);
            systemBuilder.AddMouse(collection["Mouse"]);
            systemBuilder.AddKeyboard(collection["Keyboard"]);
            systemBuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
