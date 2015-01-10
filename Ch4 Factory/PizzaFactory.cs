using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Factory
{
    class PizzaFactory
    {
        static void Main(string[] args)
        {
            Pizza pizza = orderPizza();

            Console.ReadKey();
        }

        private static Pizza orderPizza()
        {
            Pizza pizza = new Pizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
