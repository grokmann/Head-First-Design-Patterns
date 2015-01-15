using System.Collections.Generic;

namespace Ch4_Factory.Pizzas
{
    class CaliforniaStyleVeggiePizza : Pizza
   {
        public CaliforniaStyleVeggiePizza() {
            name = "California-style veggie pizza";
            dough = "whole wheat thin-crust dough";
            sauce = "heirloom tomato sauce";

            toppings.AddRange(new List<string> {
                "vegan cheese",
                "conflict-free black olives",
                "California sun-dried tomatoes",
                "organic avocados"
                }
            );
        }
    }
}
