using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_Iterator
{
    interface IMenuComponent
    {
        string getName();
        string getDescription();
        double getPrice();
        bool isVegetarian();
        void print();
        void add(IMenuComponent menuComponent);
        void remove(IMenuComponent menuComponent);
        IMenuComponent getChild(int index);
    }
}
