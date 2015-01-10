using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Factory
{
    class Pizza
   {
        public Pizza() {
            
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing pizza...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pizza...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza...");
        }
    }
}
