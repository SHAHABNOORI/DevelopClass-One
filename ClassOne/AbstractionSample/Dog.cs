using System;

namespace AbstractionSample
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Vagh Vagh");
        }
        public new void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}