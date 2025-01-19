namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator.BadExample
{
    public class ShoppingList//changing the internals of an object affect its consumers
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
    }
}