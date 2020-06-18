using System;

namespace DeveloperClass_8
{
    public class MailSender : IMessageSender
    {
        public void SendMessage(string firstName, string lastName)
        {
            Console.WriteLine($"Send Email to {firstName} {lastName}");
        }
    }
}