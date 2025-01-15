namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento
{
    public class CareTaker<ContentType>
    {
        private readonly Stack<Memento<ContentType>> _states = [];

        public void Push(Memento<ContentType> memento)
        {
            _states.Push(memento);
        }

        public Memento<ContentType> Pop()
        {
            return _states.Pop();
        }
    }
}