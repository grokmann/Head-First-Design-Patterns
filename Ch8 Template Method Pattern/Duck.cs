using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Template_Method_Pattern
{
    class Duck : IComparable
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return name + " weighs " + weight;
        }

        public int CompareTo(object obj)
        {
            Duck otherDuck = (Duck)obj;

            return weight.CompareTo(otherDuck.weight);
        }
    }
}
