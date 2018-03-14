namespace StarbuzzCoffee.Beverages
{
    //Starbuzz already had an abstract Beverage class, so no need to create an interface.
    public abstract class Beverage
    {
        public enum Size { Tall, Grande, Venti };
        Size size = Size.Tall;

        public string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return this.getSize().ToString() + " " + description;
        }

        public virtual void setSize(Size size)
        {
            this.size = size;
        }

        public virtual Size getSize()
        {
            return this.size;
        }

        public abstract decimal cost();
    }
}