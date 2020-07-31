using System;

namespace BuilderPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder = new SandwichBuilder(new HambergerIngridients());

            builder.GetSandwich().GetSandwich();
        }
    }
}
