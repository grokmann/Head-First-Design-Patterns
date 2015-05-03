using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class DinerMenuIterator : Iterator<MenuItem>
    {
        MenuItem[] items;
        int position = 0;

        public MenuItem Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DinerMenuIterator(MenuItem[] items)
        {
            MenuItem menuItem = (MenuItem)items[position];
        }

        public MenuItem MoveNext()
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if (position >= items.Length)
            {
                return false;
            }
            else
            {
                position = position + 1;
                return true;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
