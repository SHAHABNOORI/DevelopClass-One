using System;

namespace AbstractionSample
{
    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            // The body of AnimalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}