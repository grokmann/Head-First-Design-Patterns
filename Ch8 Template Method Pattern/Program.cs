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

            myTea.PrepareRecipe();
            myCoffee.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
