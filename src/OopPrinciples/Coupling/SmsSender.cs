namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending sms: {message}");
        }
    }
}