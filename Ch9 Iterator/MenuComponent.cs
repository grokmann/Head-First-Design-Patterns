using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_Iterator
{
    public abstract class MenuComponent
    {
        public void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public string GetName()
        {
            throw new NotSupportedException();
        }

        public string GetDescription()
        {
            throw new NotSupportedException();
        }

        public double GetPrice()
        {
            throw new NotSupportedException();
        }

        public bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public void Print()
        {
            throw new NotSupportedException();
        }
    }
}
