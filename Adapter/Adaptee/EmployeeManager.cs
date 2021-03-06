﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter
{
    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "Nikola"));
            this.employees.Add(new Employee(2, "Milena"));
            this.employees.Add(new Employee(3, "Dusan"));
            this.employees.Add(new Employee(4, "Milica"));
        }

        // Metoda koja vraca sve zaposlene u XML formatu.
        // Virtual da bismo je override u adapter klasi.
        public virtual string GetAllEmployees()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees, emptyNamespaces);
                return stream.ToString();
            }
        }
    }
}
