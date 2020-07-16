using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //IceCreame iceCreameOne = new SmalIceCream();
            //Console.WriteLine($"{iceCreameOne.GetName()} {iceCreameOne.GetPrice()}");


            IceCreame iceCreame = new LargeIceCream();
            Console.WriteLine($"{iceCreame.GetName()} {iceCreame.GetPrice()}");

            var iceCreamWithSmartis = new IceCreameWithSmartis(iceCreame);
            Console.WriteLine($"{iceCreamWithSmartis.GetName()} {iceCreamWithSmartis.GetPrice()}");

            var iceCreamWithSmartisAndCocolate = new IceCreameWithChocolate(iceCreamWithSmartis);
            Console.WriteLine($"{iceCreamWithSmartisAndCocolate.GetName()} {iceCreamWithSmartisAndCocolate.GetPrice()}");

            var iceCreamWithSmartisAndCocolateAndPineapple = new IceCreamWithPineappleDecorator(iceCreamWithSmartisAndCocolate);
            Console.WriteLine($"{iceCreamWithSmartisAndCocolateAndPineapple.GetName()} {iceCreamWithSmartisAndCocolateAndPineapple.GetPrice()}");

        }
    }
}
