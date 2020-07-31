using System;

namespace FactoryPattern
{
    public class Pride : ICar
    {
        public void Start() => Console.WriteLine("Pride Started...");

        public void Stop() => Console.WriteLine("Pride Stoped...");
    }
}