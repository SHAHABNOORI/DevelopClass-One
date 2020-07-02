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
            //ImageProcessor.ImageFilterHandler filterHandler = CustomeFilter;
            //Action<Image> filterHandler = CustomeFilter;
            //filterHandler += RedEyeFilter;
            //ImageProcessor.MyImageFilterHandler myImageFilterHandler = CustomerFilterOne;
            //myImageFilterHandler = myImageFilterHandler + CustomeFilterTwo;
            //myImageFilterHandler += CustomeFilterTwo;
            Func<Image,string> myImageFilterHandler= CustomerFilterOne;
            myImageFilterHandler = myImageFilterHandler + CustomeFilterTwo;
            imageProcessor.Process(new Image("c:\\myPhoto.jpg"), myImageFilterHandler);
        }

        private static string CustomeFilterTwo(Image image)
        {
            return "Custome Filter Two Applied";
        }

        private static string CustomerFilterOne(Image image)
        {
            return "Custome Filter One Applied";
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
