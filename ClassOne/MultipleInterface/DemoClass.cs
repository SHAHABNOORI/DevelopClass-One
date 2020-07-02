using System;

namespace MultipleInterface
{
    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}