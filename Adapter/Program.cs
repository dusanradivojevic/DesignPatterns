using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapter;

namespace Adapter
{
    // Program vraca sve zaposlene u xml formatu. 
    // Uz pomoc adapter dp-a, 
    // vrsimo modifikaciju metode kako bismo dobili sve zaposlene u json formatu.
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
