using Ch4_Factory.Ingredients;

namespace Ch4_Factory.Pizzerias
{
    class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new VeganCheese();
        }

        public IClams CreateClam()
        {
            return new TofuClams();
        }

        public IDough CreateDough()
        {
            return new SuperThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {
                new Avocado(),
                new Kale(),
                new BeanSprouts()
            };
            return veggies;
        }
    }
}