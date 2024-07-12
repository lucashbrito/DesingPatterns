namespace Iterator
{
    public interface IIterator<T> where T : class
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }
}
