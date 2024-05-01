using Application.Contract.Infrastructure.Resizes;

namespace Infrastructure.Resizes
{
    public class ImageResize : IImageResize
    {
        public void ResizeImage(int size)
        {
            Console.WriteLine($"Image new size is {size}");
        }
    }
}
