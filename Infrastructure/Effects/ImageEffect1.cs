using Application.Contract.Infrastructure.Effects;

namespace Persistence.Effects
{
    public class ImageEffect1 : IImageEffect1
    {
        public void UseEffect()
        {
            Console.WriteLine("You have selected effect 1");
        }
    }
}
