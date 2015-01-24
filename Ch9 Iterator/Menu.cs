using System.Collections.Generic;

namespace Ch9_Iterator
{
    public interface Menu
    {
        IEnumerable<MenuItem> createIterator();
    }
}
