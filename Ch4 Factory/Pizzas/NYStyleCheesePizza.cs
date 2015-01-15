namespace Ch4_Factory.Pizzas
{
    internal class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "New York-style sauce and cheese pizza";
            dough = "thin-crust dough";
            sauce = "marinara sauce";

            toppings.Add("grated Reggiano cheese");
        }
    }
}