namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator
{
    public class CustomCollection<T> : ICustomCollection<T>
    {
        private readonly List<T> _items = [];

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T this[int index] => _items[index];

        public int Count => _items.Count;
        public IIterator<T> CreateIterator()
        {
            return new CustomIterator(this);
        }

        private class CustomIterator : IIterator<T>
        {
            private readonly CustomCollection<T> _collection;
            private int _index = -1;

            public CustomIterator(CustomCollection<T> collection)
            {
                _collection = collection;
            }
            public T Current => _collection[_index];

            public bool MoveNext()
            {
                if (_index + 1 < _collection.Count)
                {
                    ++_index;

                    return true;
                }

                return false;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }
}