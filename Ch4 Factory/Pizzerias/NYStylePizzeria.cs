using Ch4_Factory.Ingredients;
using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class NYStylePizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (pizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
            }
            else if (pizzaType.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }

            return pizza;
        }
    }
}
