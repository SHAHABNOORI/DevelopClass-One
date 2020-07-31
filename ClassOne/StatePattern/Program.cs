using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new Tv();
            tv.IsOn = true;
            tv.OnOffPush();
            //tv.OnOffPush();
        }
    }
}
