using System;

namespace OverrideSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();
        }
    }
}
