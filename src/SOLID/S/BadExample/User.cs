using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.S.BadExample
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public void Register()
        {
            //Register user logic

            //Send email notification
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our Platform", Email);
        }
    }
}