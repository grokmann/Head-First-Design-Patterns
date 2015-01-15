using System;

namespace Ch4_Factory.Pizzas
{
    internal class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago-style deep-dish cheese pizza";
            dough = "extra-thick crust dough";
            sauce = "plum tomato sauce";

            toppings.Add("shredded mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}