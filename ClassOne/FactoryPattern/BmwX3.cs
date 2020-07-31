using System;

namespace FactoryPattern
{
    public class BmwX3 : ICar
    {
        public void Start() => Console.WriteLine("Bmw X3 Started...");

        public void Stop() => Console.WriteLine("Bmw X3 Stoped...");
    }
}