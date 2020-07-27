using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton fromEmployee = new Singleton();
            //fromEmployee.PrintDetails("From employee class");            
            //Singleton fromStudent = new Singleton();
            //fromEmployee.PrintDetails("From student class");

            Singleton.Instance.PrintDetails("From employee class");
            Singleton.Instance.PrintDetails("From student class");

            Console.ReadLine();
        }
    }
}
