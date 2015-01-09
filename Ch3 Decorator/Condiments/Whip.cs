using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override decimal cost()
        {
            return beverage.cost() + .10m;
        }
    }
}