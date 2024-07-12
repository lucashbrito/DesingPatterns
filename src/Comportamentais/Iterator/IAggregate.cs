namespace Iterator
{
    public interface IAggregate<T> where T : class
    {
        IIterator<T> CreateIterator();
    }
}
