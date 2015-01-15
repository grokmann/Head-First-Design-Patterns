using System;

namespace Ch4_Factory.Pizzas
{
    public class Pizza
    {
        public string type;

        public Pizza() {
            type = "unspecified";
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing {0} pizza...", type);
        }

        public void Bake()
        {
            Console.WriteLine("Baking {0} pizza...", type);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting {0} pizza...", type);
        }

        public void Box()
        {
            Console.WriteLine("Boxing {0} pizza...", type);
        }
    }
}
