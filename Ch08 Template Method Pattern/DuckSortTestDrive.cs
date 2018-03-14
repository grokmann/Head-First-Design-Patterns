using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Template_Method_Pattern
{
    class DuckSortTestDrive
    {
        public static void Run()
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);
        }

        public static void Display(Duck[] ducks)
        {
            foreach (Duck d in ducks)
            {
                Console.WriteLine(d);
            }
        }
    }
}
