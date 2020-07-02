using System;

namespace DelegateInActionSample
{
    public class ImageFilter
    {
        public void ApplyBrightness(Image image)
        {
            Console.WriteLine("Apply Brightness to image");
        }

        public void ApplyContrast(Image image)
        {
            Console.WriteLine("Apply Contrast to image");
        }

        public void Resize(Image image)
        {
            Console.WriteLine("Resize image");
        }


        public void RemoveRedEye(Image image)
        {
            Console.WriteLine("Remove RedEye");
        }
    }
}