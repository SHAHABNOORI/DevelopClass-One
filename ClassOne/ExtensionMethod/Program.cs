using System;
using DelegateInActionSample;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;
            //var result = number.IsGreaterThan(100);

            //string name = "Shahab";
            //var comapare = name.IsEqualTo("Noori");
            //Console.WriteLine(result);
            //Console.WriteLine(comapare);
            WithDelegate();



        }
        private static void WithDelegate()
        {
            ImageProcessor imageProcessor = new ImageProcessor();
            Func<Image, string> myImageFilterHandler = RedEyeFilter;
            myImageFilterHandler = myImageFilterHandler + RedEyeFilter;
            imageProcessor.Process(new Image("c:\\myPhoto.jpg"), myImageFilterHandler);
            imageProcessor.PrintPhoto();
        }

        private static string RedEyeFilter(Image image)
        {
            return "Red Eye Filter Two Applied";
        }
    }
}
