using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // Sealed 
    public sealed class Singleton 
    {
        // lock
        private static readonly object obj = new object();
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                // double-checked locking, koristi se jer je lock skupa operacija 
                // pa da se ne bi koristila vise puta besportrebno
                if (instance == null)
                {
                    lock(obj) // obezbedjuje singleton principe u slucaju multi thread programiranja
                    {
                        if (instance == null)
                            instance = new Singleton();                    
                    }
                }
                // umesto ovog uslova, zastita se moze obezbediti sa eager loading

                return instance;
            }
        }
        private Singleton()
        {

        } 

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
