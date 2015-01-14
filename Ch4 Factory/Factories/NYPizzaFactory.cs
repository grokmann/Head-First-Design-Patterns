using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Factories
{
    class NYPizzaFactory : SimplePizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            Console.WriteLine("\nNew York-Style pizza coming up!");

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
