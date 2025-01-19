namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator
{
    public interface IIterator<T>
    {
        T Current {get;}
        bool MoveNext();
        void Reset();
    }
}