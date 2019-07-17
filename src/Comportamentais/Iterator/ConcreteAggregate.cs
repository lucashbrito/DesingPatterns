using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public int Count
        {
            get { return _items.Count; }
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
