using System;
using System.Collections.Generic;
using Ch4_Factory.Ingredients;

namespace Ch4_Factory.Pizzas
{
    public abstract class Pizza
    {
        public string name;

        public IDough dough;
        public ISauce sauce;
        public IVeggies[] veggies;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClams clam;

        public abstract void Prepare();

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

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string ToString()
        {
            // code to print pizza here
        }
    }
}
