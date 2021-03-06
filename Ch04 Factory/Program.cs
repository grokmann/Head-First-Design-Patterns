﻿using Ch4_Factory.Pizzas;
using Ch4_Factory.Pizzerias;
using System;

namespace Ch4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria nyPizzeria = new NYStylePizzeria();
            Pizzeria chicagoPizzeria = new ChicagoStylePizzeria();
            Pizzeria californiaPizzeria = new CaliforniaStylePizzeria();

            Pizza pizza = nyPizzeria.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + ".\n");

            pizza = chicagoPizzeria.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + ".\n");

            pizza = californiaPizzeria.OrderPizza("cheese");
            Console.WriteLine("Sunshine Otter ordered a " + pizza.GetName() + ".\n");

            Console.ReadKey();
        }
    }
}
