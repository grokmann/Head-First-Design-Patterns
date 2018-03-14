using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Singleton
{
    public class ClassicSingleton
    {
        private static ClassicSingleton uniqueInstance;

        private ClassicSingleton() { }

        public static ClassicSingleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                Console.WriteLine("Creating new, unique instance of ClassicSingleton");
                uniqueInstance = new ClassicSingleton();
            }
            else
            {
                Console.WriteLine("Using the previously created instance of ClassicSingleton");
            }

            return uniqueInstance;
        }
    }
}
