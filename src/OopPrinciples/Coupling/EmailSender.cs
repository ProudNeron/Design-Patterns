using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            //Email Logic
            Console.WriteLine("Sending email: " + message);
        }
    }
}