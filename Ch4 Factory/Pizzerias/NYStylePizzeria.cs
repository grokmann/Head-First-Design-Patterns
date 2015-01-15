using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class NYStylePizzeria : Pizzeria
    {
        public override Pizza CreatePizza(String pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
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
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
