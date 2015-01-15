using System.Collections.Generic;

namespace Ch4_Factory.Pizzas
{
    class ChicagoStyleVeggiePizza : Pizza
   {
        public ChicagoStyleVeggiePizza() {
            name = "Chicago-style veggie pizza";
            dough = "extra-thick crust dough";
            sauce = "plum tomato sauce";

            toppings.AddRange(new List<string> {
                "shredded mozzarella cheese",
                "broccoli",
                "sun-dried tomatoes",
                "green peppers"
                }
            );
        }
    }
}
