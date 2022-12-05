using System.Collections;

namespace Iterator
{
    internal class ConcreteAggregate : IAggregate
    {
        private ArrayList _items = new ArrayList();

        public InterfaceIterator CreateIterator() => new ConcreteIterator(this);

        public object? this[int index] => _items[index];

        public int Count => _items.Count;

        public void Add(object value) => _items.Add(value);
    }
}
