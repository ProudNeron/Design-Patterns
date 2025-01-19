namespace DesignPatterns.src.DesignPatterns.Behavioural.State.GoodExample
{
    public class Document
    {
        public IState CurrentState {get; set;}
        public UserRoles UserRole {get; set;}

        public Document(IState initialState, UserRoles userRole)
        {
            CurrentState = initialState;
            UserRole = userRole;
        }

        public void Publish()
        {
            CurrentState.Publish();
        }
    }
}