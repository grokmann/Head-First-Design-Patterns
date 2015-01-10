using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    class Whip : CondimentDecorator
    {
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
            var cost = this.beverage.cost();

            switch (this.beverage.getSize())
            {
                case Size.Tall:
                    cost += .05m;
                    break;
                case Size.Grande:
                    cost += .10m;
                    break;
                case Size.Venti:
                    cost += .15m;
                    break;
            }

            return cost;
        }
    }
}