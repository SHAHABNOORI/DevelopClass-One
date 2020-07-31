using System;

namespace FactoryPattern
{
    public class BmwS7 : ICar
    {
        public void Start() => Console.WriteLine("Bmw S7 Started...");

        public void Stop() => Console.WriteLine("Bmw S7 Stoped...");
    }
}