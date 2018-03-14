namespace StarbuzzCoffee.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public override decimal cost()
        {
            var cost = 0.00m;

            switch (this.getSize())
            {
                case Size.Tall:
                    cost += 1.05m;
                    break;
                case Size.Grande:
                    cost += 1.15m;
                    break;
                case Size.Venti:
                    cost += 1.25m;
                    break;
            }

            return cost;
        }
    }
}