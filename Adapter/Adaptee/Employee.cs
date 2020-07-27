using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    [Serializable]
    public class Employee
    {
        public Employee() { }
        public Employee(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }
}
