using System;

namespace DelegateInActionSample
{
    public class ImageProcessor
    {
        public delegate void ImageFilterHandler(Image image);
        public delegate string MyImageFilterHandler(Image image);

        public void Process(Image image, ImageFilterHandler filterHandler)
        {
            filterHandler.Invoke(image);
            //filterHandler(image);
        }

        public void Process(Image image, MyImageFilterHandler handler)
        {
            var result = handler.Invoke(image);
            Console.WriteLine(result);
        }

        public void Process(Image image, Func<Image, string> handler)
        {
            var result = handler.Invoke(image);
            Console.WriteLine(result);
        }

        public void Process(Image image, Action<Image> handler)
        {
            handler.Invoke(image);
        }

        public void Process(Image image)
        {
            var filters = new ImageFilter();
            filters.ApplyBrightness(image);
            filters.ApplyContrast(image);
            filters.Resize(image);
        }

        //public  void PrintPhoto()
        //{
        //    Console.WriteLine($"Photo is Printing");
        //}
    }
}