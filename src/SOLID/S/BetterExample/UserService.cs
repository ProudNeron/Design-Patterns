namespace DesignPatterns.src.SOLID.S.BetterExample
{
    public class UserService
    {
        public void Register(User user)
        {
            //Register user logic

            //Send email notification
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our Platform", user.Email);
        }
    }
}