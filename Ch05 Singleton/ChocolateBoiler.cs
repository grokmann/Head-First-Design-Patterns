using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        // Keyword volatile is used as a hint to the compiler that this data member is accessed by multiple threads.
        private volatile static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null) {
                lock (uniqueInstance)
                {
                    if (uniqueInstance == null) {
                        Console.WriteLine("Creating new, unique instance of ChocolateBoiler");
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }
            else
            {
                Console.WriteLine("Using the previously created instance of ChocolateBoiler");
            }

            return uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                //drain the boiled milk and chocolate
                empty = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
