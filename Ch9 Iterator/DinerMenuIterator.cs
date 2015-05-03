using System;

namespace Ch9_Iterator
{
    public class DinerMenuIterator : Iterator<MenuItem>
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
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
            if (position >= items.Length)
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
