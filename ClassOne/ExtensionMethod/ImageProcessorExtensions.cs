using System;
using DelegateInActionSample;

namespace ExtensionMethod
{
    public static class ImageProcessorExtensions
    {
        public static void PrintPhoto(this ImageProcessor processor)
        {
            Console.WriteLine($"Photo is Printing");
        }
    }
}