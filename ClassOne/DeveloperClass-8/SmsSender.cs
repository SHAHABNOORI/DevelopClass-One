using System;

namespace DeveloperClass_8
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string firstName, string lastName)
        {
            Console.WriteLine($"Send Sms to {firstName} {lastName}");
        }
    }
}