namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento
{
    public class Memento<ContentType>
    {
        private readonly ContentType? _content;

        public Memento(ContentType content)
        {
            _content = content;
        }
        public ContentType GetContent()
        {
            return _content;
        }
    }
}