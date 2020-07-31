using System;

namespace FactoryPattern
{
    public class Bmw : ICar
    {
        public void Start() => Console.WriteLine("Bmw Started...");

        public void Stop() => Console.WriteLine("Bmw Stoped...");
    }
}