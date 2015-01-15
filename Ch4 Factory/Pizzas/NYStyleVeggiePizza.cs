using System.Collections.Generic;

namespace Ch4_Factory.Pizzas
{
    class NYStyleVeggiePizza : Pizza
   {
        public NYStyleVeggiePizza() {
            name = "New York-style veggie pizza";
            dough = "thin-crust dough";
            sauce = "marinara sauce";

            toppings.AddRange(new List<string> {
                "grated Reggiano cheese",
                "black olives",
                "sun-dried tomatoes",
                "green peppers"
                }
            );
        }
    }
}
