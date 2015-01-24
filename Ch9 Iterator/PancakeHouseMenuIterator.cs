﻿using System.Collections;

namespace Ch9_Iterator
{
    public class PancakeHouseMenuIterator : Iterator<MenuItem>
    {
        ArrayList items;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList items)
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
