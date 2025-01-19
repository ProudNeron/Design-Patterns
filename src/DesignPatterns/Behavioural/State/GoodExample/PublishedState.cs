namespace DesignPatterns.src.DesignPatterns.Behavioural.State.GoodExample
{
    public class PublishedState : IState
    {
        private readonly Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            //do nothing
        }
    }
}