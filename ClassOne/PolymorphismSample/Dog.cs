using System;

namespace PolymorphismSample
{
    class Dog : Animal  // Derived class (child) 
    {
        public new void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}