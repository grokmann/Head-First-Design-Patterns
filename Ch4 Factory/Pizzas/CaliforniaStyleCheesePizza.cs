using System.Collections.Generic;

namespace Ch4_Factory.Pizzas
{
    class CaliforniaStyleCheesePizza : Pizza
   {
        public CaliforniaStyleCheesePizza() {
            name = "California-style cheese pizza";
            dough = "whole wheat thin-crust dough";
            sauce = "heirloom tomato sauce";

            toppings.AddRange(new List<string> {
                "vegan cheese",
                "good vibes",
                "skateboards",
                "pine nuts",
                "local water(!)"
                }
            );
        }
    }
}
