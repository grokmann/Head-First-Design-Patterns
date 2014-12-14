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
            Console.WriteLine(@"~~~~~~~~~~~~ Begin Strategy Pattern ~~~~~~~~~~~~");

            Duck mallard = new MallardDuck();
            Duck redhead = new RedheadDuck();
            Duck rubber = new RubberDuck();

            mallard.quack();
            redhead.quack();
            rubber.quack();

            mallard.display();
            redhead.display();
            rubber.display();

            mallard.fly();
            redhead.fly();
            rubber.fly(); //rubber ducks should *not* fly

            Console.ReadKey();
        }
    }
}
