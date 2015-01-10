using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public override abstract string getDescription();

        public override Size getSize()
        {
            return beverage.getSize();
        }
        public override void setSize(Size size)
        {
            this.beverage.setSize(size);
        }
    }
}

