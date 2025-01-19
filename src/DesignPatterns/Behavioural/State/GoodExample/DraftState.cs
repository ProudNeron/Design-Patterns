namespace DesignPatterns.src.DesignPatterns.Behavioural.State.GoodExample
{
    public class DraftState : IState
    {
        private readonly Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            _document.CurrentState = new ModerationState(_document);
        }
    }
}