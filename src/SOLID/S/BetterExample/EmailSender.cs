namespace DesignPatterns.src.SOLID.S.BetterExample
{
    public class EmailSender
    {
        public void SendEmail(string message, string recipient)
        {
            //Email sending Logic
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}