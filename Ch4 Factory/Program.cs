using Ch4_Factory.Pizzas;
using Ch4_Factory.Pizzerias;
using System;

namespace Ch4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria nyPizzeria = new NYStylePizzeria();

            Pizza pizza = nyPizzeria.OrderPizza("cheese");
            pizza = nyPizzeria.OrderPizza("veggie");

            Pizzeria chicagoPizzeria = new ChicagoStylePizzeria();

            pizza = chicagoPizzeria.OrderPizza("cheese");
            pizza = chicagoPizzeria.OrderPizza("veggie");

            Console.ReadKey();
        }
    }
}
