using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class CafeMenuIterator  : Iterator<MenuItem>
    {
        Hashtable items;
        int position = 0;

        public CafeMenuIterator(Hashtable items)
        {
            this.items = items;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = (MenuItem)items[position];
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
