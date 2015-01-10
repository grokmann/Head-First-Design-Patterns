namespace StarbuzzCoffee.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override decimal cost()
        {
            var cost = 0.00m;

            switch (this.getSize())
            {
                case Size.Tall:
                    cost += 1.99m;
                    break;
                case Size.Grande:
                    cost += 2.09m;
                    break;
                case Size.Venti:
                    cost += 2.19m;
                    break;
            }

            return cost;
        }
    }
}