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
        public override Size getSize()
        {
            return this.beverage.getSize();
        }

        public override void setSize(Size size)
        {
            this.beverage.setSize(size);
        }

        public override decimal cost()
        {
            var cost = beverage.cost();

            switch (beverage.getSize())
            {
                case Size.Tall:
                    cost += .10m;
                    break;
                case Size.Grande:
                    cost += .15m;
                    break;
                case Size.Venti:
                    cost += .20m;
                    break;
            }

            return cost;
        }
    }
}