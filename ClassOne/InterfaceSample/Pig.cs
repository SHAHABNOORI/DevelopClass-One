using System;

namespace InterfaceSample
{
    // Pig "implements" the IAnimal interface
    public class Pig : IAnimal
    {
        public void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}