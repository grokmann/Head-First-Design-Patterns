using System;
using Ch4_Factory.Pizzas;

namespace Ch4_Factory.Pizzerias
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza;
            pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            Console.WriteLine("");

            return pizza;
        }

        public abstract Pizza CreatePizza(String pizzaType);
    }
}
