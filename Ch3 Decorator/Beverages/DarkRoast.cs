namespace StarbuzzCoffee.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override decimal cost()
        {
            var cost = 0.00m;

            switch (this.getSize())
            {
                case Size.Tall:
                    cost += .99m;
                    break;
                case Size.Grande:
                    cost += 1.09m;
                    break;
                case Size.Venti:
                    cost += 1.19m;
                    break;
            }

            return cost;
        }
    }
}