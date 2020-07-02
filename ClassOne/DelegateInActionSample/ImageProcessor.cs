namespace DelegateInActionSample
{
    public class ImageProcessor
    {
        public delegate void ImageFilterHandler(Image image);

        public void Process(Image image, ImageFilterHandler filterHandler)
        {
            filterHandler.Invoke(image);
            //filterHandler(image);
        }

        public void Process(Image image)
        {
            var filters = new ImageFilter();
            filters.ApplyBrightness(image);
            filters.ApplyContrast(image);
            filters.Resize(image);
        }
    }
}