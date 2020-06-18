using System;

namespace DeveloperClass_8
{
    public class Daneshjoo : Person, Itest, Iuser, IHasan
    {
        public Daneshjoo()
        {
            MelliCode = Guid.NewGuid().ToString();
        }

        public Guid DaneshjooId { get; set; }

        public string ShowMelliCode()
        {
            return MelliCode;
        }

        void Itest.SendMessage()
        {
            Console.WriteLine("Test.....");
        }

        void Iuser.SendMessage()
        {
            Console.WriteLine("User.....");

        }

        void IHasan.SendMessage()
        {
            Console.WriteLine("Hasan.....");
        }
    }

    public interface Itest
    {
        void SendMessage();
    }

    public interface Iuser
    {
        void SendMessage();

    }

    public interface IHasan
    {
        void SendMessage();

    }
}