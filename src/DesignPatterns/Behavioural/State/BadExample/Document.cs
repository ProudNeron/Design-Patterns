namespace DesignPatterns.src.DesignPatterns.Behavioural.State.BadExample
{
    public class Document
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentRole { get; set; }

        public void Publish() //violated OCP
        {
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentRole == UserRoles.Admin)
                {
                    State = DocumentStates.Publish;
                }
            }
            else if (State == DocumentStates.Publish)
            {
                // do nothing
            }
        }
    }
}