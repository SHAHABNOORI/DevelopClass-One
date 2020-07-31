using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteSetting setting = SiteSetting.GetInstance();

            Console.WriteLine(setting.SiteName);
        }
    }
}
