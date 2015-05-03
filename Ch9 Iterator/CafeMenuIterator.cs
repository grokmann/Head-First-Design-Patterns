using System;
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

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MenuItem IEnumerator<MenuItem>.Current
        {
            get
            {
                MenuItem menuItem = items[position];
                return menuItem;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
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

        public bool MoveNext()
        {
            if (position >= items.Count)
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
            position = 0;
        }
    }
}
