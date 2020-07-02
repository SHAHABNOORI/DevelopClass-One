using System;

namespace AbstractionSample
{
    // Abstract class
    public abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}