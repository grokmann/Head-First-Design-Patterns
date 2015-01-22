using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea myTea = new Tea();
            Coffee myCoffee = new Coffee();
            CoffeeWithHook myCoffeeWithHook = new CoffeeWithHook();

            myTea.PrepareRecipe();
            myCoffee.PrepareRecipe();

            Console.WriteLine("\nMaking coffee with hook...");
            myCoffeeWithHook.PrepareRecipe();

            DuckSortTestDrive.Run();

            Console.ReadKey();
        }
    }
}
