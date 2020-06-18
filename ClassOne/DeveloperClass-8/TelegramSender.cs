using System;

namespace DeveloperClass_8
{
    public class TelegramSender : IMessageSender
    {
        public void SendMessage(string firstName, string lastName)
        {
            Console.WriteLine($"Send Message from telegram to {firstName} {lastName}");
        }
    }
}