using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            WriteLine("Sending email...");
        }
        private void Connect()
        {
            WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            WriteLine("Authenticating...");
        }

        private void Dissconect()
        {
            WriteLine("Disconnecting from email server...");
        }
    }
}