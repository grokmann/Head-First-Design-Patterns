namespace Ch4_Factory.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            CreateVeggies veggies() = { new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }
    }
}
