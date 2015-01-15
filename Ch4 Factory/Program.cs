using Ch4_Factory.Pizzas;
using Ch4_Factory.Pizzerias;
using System;

namespace Ch4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria NYPizzeria = new NYStylePizzeria();

            Pizza pizza = NYPizzeria.OrderPizza("cheese");
            pizza = NYPizzeria.OrderPizza("veggie");

            Pizzeria ChicagoPizzeria = new ChicagoStylePizzeria();

            pizza = ChicagoPizzeria.OrderPizza("cheese");
            pizza = ChicagoPizzeria.OrderPizza("veggie");

            Console.ReadKey();
        }
    }
}
