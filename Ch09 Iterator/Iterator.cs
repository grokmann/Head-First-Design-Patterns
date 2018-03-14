namespace Ch9_Iterator
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
    }
}