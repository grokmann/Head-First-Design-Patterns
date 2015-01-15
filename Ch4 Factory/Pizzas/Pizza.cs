using System;
using System.Collections.Generic;

namespace Ch4_Factory.Pizzas
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            foreach (var topping in toppings) {
                Console.WriteLine("\t" + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official Pizzeria box");
        }

        public string GetName()
        {
            return name;
        }
    }
}
