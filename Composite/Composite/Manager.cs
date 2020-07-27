using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Component;

namespace Composite.Composite
{
    public class Manager : IEmployee 
    {
        public List<IEmployee> SubOrdinates;
        public string Name { get; set; }
        public string Department { get; set; }

        public Manager() { }
        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            SubOrdinates = new List<IEmployee>();
        }

        public void GetDetails()
        {
            Console.WriteLine($"\n{Name} - {Department} - Manager(Composite)");
            foreach (IEmployee emp in SubOrdinates)
            {
                emp.GetDetails();
            }
        }
    }
}
