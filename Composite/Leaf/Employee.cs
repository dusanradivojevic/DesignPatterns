using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Component;

namespace Composite.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee() { }
        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name} from {Department} (Leaf)");
        }
    }
}
