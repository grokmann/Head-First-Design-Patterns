using System;
using Ch4_Factory.Factories;
using Ch4_Factory.Pizzas;

namespace Ch4_Factory
{
    class Pizzeria
    {
        SimplePizzaFactory factory;

        public Pizzeria(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria(new SimplePizzaFactory());

            Pizza pizza1 = pizzeria.OrderPizza("cheese");
            Pizza pizza2 = pizzeria.OrderPizza("greek");
            Pizza pizza3 = pizzeria.OrderPizza("pepperoni");
            Pizza pizza4 = pizzeria.OrderPizza("clam");
            Pizza pizza5 = pizzeria.OrderPizza("veggie");

            Console.ReadKey();
        }

        private Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = factory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
