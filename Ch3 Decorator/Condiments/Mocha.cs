﻿using StarbuzzCoffee.Beverages;

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
                    cost += .15m;
                    break;
                case Size.Grande:
                    cost += .20m;
                    break;
                case Size.Venti:
                    cost += .25m;
                    break;
            }

            return cost;
        }
    }
}
