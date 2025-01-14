using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.S.BadExample
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