using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.Singleton
{
    public class MySingleton
    {
        private static object _instanciatonLock = new object();
        private static MySingleton _uniqueInstance;

        private MySingleton()
        {
        }

        public static MySingleton GetInstance()
        {
            // n.b. this is potentially not thread-safe, in case of a race condition, 
            // hence the use of the lock statement
            lock (_instanciatonLock)
            {
                if (_uniqueInstance is null)
                {
                    _uniqueInstance = new MySingleton();
                    Console.WriteLine("New singleton created");
                }
            }

            Console.WriteLine("returning the singleton...");
            return _uniqueInstance;
        }
    }
}
