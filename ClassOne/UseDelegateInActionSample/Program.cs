using System;
using DelegateInActionSample;

namespace UseDelegateInActionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutDelegate();
            WithDelegate();
        }

        private static void WithDelegate()
        {
            ImageProcessor imageProcessor = new ImageProcessor();
            //var filters = new ImageFilter();
            ImageProcessor.ImageFilterHandler filterHandler = CustomeFilter;
            filterHandler += RedEyeFilter;
            imageProcessor.Process(new Image("c:\\myPhoto.jpg"), filterHandler);
        }

        private static void RedEyeFilter(Image image)
        {
            Console.WriteLine("Red Eye filter applied");
        }

        private static void CustomeFilter(Image image)
        {
            Console.WriteLine("Custome filter applied");
        }

        private static void WithoutDelegate()
        {
            ImageProcessor imageProcessor = new ImageProcessor();
            imageProcessor.Process(new Image("c:\\myPhoto.jpg"));
        }
    }
}
