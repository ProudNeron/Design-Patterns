namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator.GoodExample
{
    public class ShoppingList
    {
        private readonly List<string> _list = [];

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop(string itemName)
        {
            var last = _list.Last();

            _list.Remove(last);

            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }

        IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<string>
        {
            private readonly ShoppingList _shoppingList;
            private int _index;
            public ListIterator(ShoppingList list)
            {
                _shoppingList = list;
            }
            public string Current()
            {
                return _shoppingList._list[_index];
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

            public void Next()
            {
                ++_index;
            }
        }
    }
}