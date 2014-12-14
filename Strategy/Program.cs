﻿using System;
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

            mallard.quack();
            redhead.quack();

            mallard.display();
            redhead.display();

            mallard.fly();
            redhead.fly();

            Console.ReadKey();
        }
    }
}
