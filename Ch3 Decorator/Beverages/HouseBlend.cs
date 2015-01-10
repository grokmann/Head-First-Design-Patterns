namespace StarbuzzCoffee.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override decimal cost()
        {
            var cost = 0.00m;

            switch (this.getSize())
            {
                case Size.Tall:
                    cost += .89m;
                    break;
                case Size.Grande:
                    cost += .99m;
                    break;
                case Size.Venti:
                    cost += 1.09m;
                    break;
            }

            return cost;
        }
    }
}