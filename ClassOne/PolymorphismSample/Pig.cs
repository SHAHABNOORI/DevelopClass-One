using System;

namespace PolymorphismSample
{
    class Pig : Animal  // Derived class (child) 
    {
        public new void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}