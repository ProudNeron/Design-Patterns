namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator
{
    public interface ICustomCollection<T>
    {
        IIterator<T> CreateIterator();
    }
}