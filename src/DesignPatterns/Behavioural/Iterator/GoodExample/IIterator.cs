namespace DesignPatterns.src.DesignPatterns.Behavioural.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}