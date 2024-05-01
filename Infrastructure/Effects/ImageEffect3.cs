using Application.Contract.Infrastructure.Effects;

namespace Persistence.Effects
{
    public class ImageEffect3 : IImageEffect3
    {
        public void UseEffect()
        {
            Console.WriteLine("You have selected effect 3");
        }       
    }
}
