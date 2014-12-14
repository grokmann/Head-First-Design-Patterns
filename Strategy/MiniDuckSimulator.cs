using SimUDuck.Behaviors;
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
            Duck model = new ModelDuck();
            
            RunSimulation(mallard);

            RunSimulation(redhead);

            RunSimulation(rubber); //rubber ducks should *not* fly

            RunSimulation(model);
            model.setFlyBehavior(new FlyRocketPowered());
            Console.WriteLine("ModelDuck fly behavior reset.");
            RunSimulation(model);

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
