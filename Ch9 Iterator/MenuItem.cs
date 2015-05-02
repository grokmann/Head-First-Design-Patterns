using System;

namespace Ch9_Iterator
{
    public class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool IsVegetarian()
        {
            return vegetarian;
        }

        public void Print()
        {
            Console.Write("\t" + GetName());
            if (IsVegetarian())
            {
                Console.Write(" (v) ");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("\t-- " + GetDescription());
        }
    }
}
