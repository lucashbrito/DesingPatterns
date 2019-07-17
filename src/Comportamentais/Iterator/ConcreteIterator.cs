namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
        private bool _isDone = false;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone() => _isDone;

        public override object Next()
        {
            object ret = null;

            if (_current < _aggregate.Count - 1)
                ret = _aggregate[++_current];
            else
            {
                CheckingIsDone();
            }

            return ret;
        }

        private void CheckingIsDone()
        {
            if (_current == _aggregate.Count - 1)
                _isDone = true;
        }
    }
}
