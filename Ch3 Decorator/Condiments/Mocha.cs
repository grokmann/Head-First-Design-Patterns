using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override decimal cost()
        {
            return beverage.cost() + .20m;
        }
    }
}
