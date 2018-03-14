using Ch4_Factory.Ingredients;
using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class ChicagoStylePizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (pizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago Style Pepperoni Pizza");
            }
            else if (pizzaType.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
            }

            return pizza;
        }
    }
}
