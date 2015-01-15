using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class ChicagoStylePizzeria : Pizzeria
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            Console.WriteLine("\nChicago-Style pizza coming up!");

            if (pizzaType.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
