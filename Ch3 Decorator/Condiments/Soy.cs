using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override decimal cost()
        {
            return beverage.cost() + .15m;
        }
    }
}