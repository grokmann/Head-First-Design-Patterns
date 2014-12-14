using SimUDuck.Ducks;
using System;

namespace SimUDuck
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin SimUDuck ~~~~~~~~~~~~\r\n");

            Duck mallard = new MallardDuck("Mallard");
            Duck redhead = new RedheadDuck("Redhead");
            Duck rubber = new RubberDuck("Rubber Ducky");

            RunSimulation(mallard);

            RunSimulation(redhead);

            RunSimulation(rubber); //rubber ducks should *not* fly

            Console.ReadKey();
        }

        static public void RunSimulation(Duck duck)
        {
            Console.WriteLine("\t+++ Begin simulation of " + duck.GetType() + " +++");
            duck.performQuack();
            duck.display();
            duck.performFly();
            Console.WriteLine();
        }
    }
}
