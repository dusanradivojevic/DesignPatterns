using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder.Builder.ConcreteBuilder;
using Builder.Builder.IBuilder;
using Builder.Builder.Director;
using System.Collections.Specialized;
using Builder.Builder.Product;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private NameValueCollection createCollection()
        {
            NameValueCollection inputs = new NameValueCollection();
            inputs.Add("Drive", cmbHDD.SelectedItem as string);
            inputs.Add("RAM", cmbRAM.SelectedItem as string);
            inputs.Add("Keyboard", cmbKeyboard.SelectedItem as string);
            inputs.Add("Mouse", cmbMouse.SelectedItem as string);
            inputs.Add("TouchScreen", cmbTouch.SelectedItem as string);
            return inputs;
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            NameValueCollection inputs = createCollection();

            // Step 1 Concrete builder
            ISystemBuilder systemBuilder = new DesktopBuilder();

            // Step 2 Director
            ConfigurationBuilder director = new ConfigurationBuilder();
            director.BuildSystem(systemBuilder, inputs);

            // Step 3 return the system
            ComputerSystem system = systemBuilder.GetSystem();

            txtResult.Text =
                string.Format($"RAM: {system.RAM}, HDDSize: {system.HDDSize}, " +
                $"Keyboard: {system.Keyboard}, Mouse: {system.Mouse}");
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            NameValueCollection inputs = createCollection();

            // Step 1 Concrete builder
            ISystemBuilder systemBuilder = new LaptopBuilder();

            // Step 2 Director
            ConfigurationBuilder director = new ConfigurationBuilder();
            director.BuildSystem(systemBuilder, inputs);

            // Step 3 return the system
            ComputerSystem system = systemBuilder.GetSystem();

            txtResult.Text =
                string.Format($"RAM: {system.RAM}, HDDSize: {system.HDDSize}, " +
                $"Mouse: {system.Mouse}, TouchScreen: {system.TouchScreen}");
        }
    }
}
