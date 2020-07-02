using System;

namespace OverrideSample
{
    class Pig : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}