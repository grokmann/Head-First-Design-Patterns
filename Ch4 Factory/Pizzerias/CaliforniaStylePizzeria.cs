using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class CaliforniaStylePizzeria : Pizzeria
    {
        public override Pizza CreatePizza(String pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType.Equals("cheese"))
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
