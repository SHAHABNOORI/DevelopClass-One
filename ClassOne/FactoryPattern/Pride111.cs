using System;

namespace FactoryPattern
{
    public class Pride111 : ICar
    {
        public void Start() => Console.WriteLine("Pride 111 Cross Started...");

        public void Stop() => Console.WriteLine("Pride 111 Cross Stoped...");
    }
}