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
            Pizzeria pizzeria = new Pizzeria(new NYPizzaFactory());

            Pizza pizza = pizzeria.OrderPizza("veggie");

            pizzeria = new Pizzeria(new ChicagoPizzaFactory());

            pizza = pizzeria.OrderPizza("veggie");

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
