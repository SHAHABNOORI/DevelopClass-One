using System;

namespace BuilderPatternSample
{
    public class Sandwich
    {
        public BreadType BreadType;

        public MeatType MeatType;

        public CheezType CheezType;


        public void GetSandwich()
        {
            Console.WriteLine("Sandwich With : ");

            Console.WriteLine(BreadType);
            Console.WriteLine(MeatType);
            Console.WriteLine(CheezType);
        }
    }
}