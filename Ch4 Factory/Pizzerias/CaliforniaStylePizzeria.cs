using Ch4_Factory.Ingredients;
using Ch4_Factory.Pizzas;
using System;

namespace Ch4_Factory.Pizzerias
{
    class CaliforniaStylePizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(String pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();

            if (pizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("California Style Cheese Pizza");
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("California Style Pepperoni Pizza");
            }
            else if (pizzaType.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("California Style Clam Pizza");
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("California Style Veggie Pizza");
            }

            return pizza;
        }
    }
}
