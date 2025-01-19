namespace DesignPatterns.src.DesignPatterns.Behavioural.State.GoodExample
{
    public class ModerationState : IState
    {
        private readonly Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            if (_document.UserRole == UserRoles.Admin)
            {
                _document.CurrentState = new PublishedState(_document);
            }
        }
    }
}