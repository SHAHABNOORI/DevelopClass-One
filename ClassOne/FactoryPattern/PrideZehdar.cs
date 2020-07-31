using System;

namespace FactoryPattern
{
    public class PrideZehdar:ICar
    {
        public void Start() => Console.WriteLine("Pride Zehdar Started...");

        public void Stop() => Console.WriteLine("Pride Zehdar Stoped...");
    }
}