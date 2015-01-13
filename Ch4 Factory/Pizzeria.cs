using System;
using Ch4_Factory.Factories;
using Ch4_Factory.Pizzas;

namespace Ch4_Factory
{
    class Pizzeria
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = OrderPizza("cheese");
            Pizza pizza2 = OrderPizza("greek");
            Pizza pizza3 = OrderPizza("pepperoni");
            Pizza pizza4 = OrderPizza("clam");
            Pizza pizza5 = OrderPizza("veggie");

            Console.ReadKey();
        }

        private static Pizza OrderPizza(string pizzaType)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            Pizza pizza = factory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
