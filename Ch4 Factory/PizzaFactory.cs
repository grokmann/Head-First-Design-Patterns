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
            Pizza pizza1 = orderPizza("cheese");
            Pizza pizza2 = orderPizza("greek");
            Pizza pizza3 = orderPizza("pepperoni");

            Console.ReadKey();
        }

        private static Pizza orderPizza(string type)
        {
            Pizza pizza = new Pizza();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            } else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            } else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
