using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ch9_Iterator
{
    public class CafeMenuIterator  : Iterator<MenuItem>
    {
        List<MenuItem> items;
        int position = 0;

        public CafeMenuIterator(Hashtable items)
        {
            this.items = items.Values.OfType<MenuItem>().ToList<MenuItem>();
        }

        public MenuItem Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= items.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
