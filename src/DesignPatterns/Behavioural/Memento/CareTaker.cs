namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento
{
    public class CareTaker<ContentType>
    {
        private readonly Stack<Memento<ContentType>> _states = [];
        private readonly IOriginator<ContentType> _originator;

        public CareTaker(IOriginator<ContentType> originator)
        {
            _originator = originator;
        }

        public void Push()
        {
            _states.Push(_originator.SaveState());
        }

        public Memento<ContentType> Pop()
        {
            return _states.Pop();
        }
    }
}