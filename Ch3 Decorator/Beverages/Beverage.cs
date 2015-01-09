namespace StarbuzzCoffee.Beverages
{
    //Starbuzz already had an abstract Beverage class, so no need to create an interface.
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract decimal cost();
    }
}