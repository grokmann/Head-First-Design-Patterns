using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin Strategy Pattern ~~~~~~~~~~~~\r\n");

            Duck mallard = new MallardDuck();
            Duck redhead = new RedheadDuck();
            Duck rubber = new RubberDuck();

            Console.WriteLine("\t+++ Begin mallard duck simulation +++");
            RunSimulation(mallard);

            Console.WriteLine("\t+++ Begin redhead duck simulation +++");
            RunSimulation(redhead);

            Console.WriteLine("\t+++ Begin rubber duck simulation +++");
            RunSimulation(rubber); //rubber ducks should *not* fly

            Console.ReadKey();
        }

        static public void RunSimulation(Duck duck)
        {
            duck.quack();
            duck.display();
            duck.fly();
            Console.WriteLine();
        }
    }
}
