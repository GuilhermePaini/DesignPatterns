namespace Iterator
{
    internal class ConcreteIterator : InterfaceIterator
    {
        private ConcreteAggregate _aggregate;
        int index;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            index = -1;
        }

        public bool Next()
        {
            index++;
            return index < _aggregate.Count;
        }

        public object? Current
        {
            get
            {
                if (index < _aggregate.Count)
                    return _aggregate[index];
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
