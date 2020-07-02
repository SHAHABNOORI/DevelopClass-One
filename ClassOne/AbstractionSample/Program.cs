namespace AbstractionSample
{
    class Program
    {
        static void Main(string[] args) {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.AnimalSound();
            myPig.Sleep();


            Dog myDog = new Dog();  // Create a Dog object
            myDog.AnimalSound();
            myDog.Sleep();
        }
    }
}
