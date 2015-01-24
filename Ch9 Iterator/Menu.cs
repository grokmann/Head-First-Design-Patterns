using System.Collections.Generic;

namespace Ch9_Iterator
{
    public interface Menu
    {
        Iterator<MenuItem> CreateIterator();
    }
}
