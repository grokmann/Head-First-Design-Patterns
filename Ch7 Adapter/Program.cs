using System;
using System.Collections;

namespace Ch7_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
