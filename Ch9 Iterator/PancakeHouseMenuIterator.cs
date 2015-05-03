using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class PancakeHouseMenuIterator : Iterator<MenuItem>
    {
        ArrayList items;
        int position = 0;

        public MenuItem Current
        {
            get
            {
                MenuItem menuItem = (MenuItem)items[position];
                return menuItem;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                MenuItem menuItem = (MenuItem)items[position];
                return menuItem;
            }
        }

        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }

        public MenuItem MoveNext()
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if (position >= items.Count)
            {
                position += 1;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
