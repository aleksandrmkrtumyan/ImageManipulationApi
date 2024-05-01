using Application.Contract.Infrastructure.Effects;

namespace Persistence.Effects
{
    public class ImageEffect2 : IImageEffect2
    {
        public void UseEffect()
        {
            Console.WriteLine("You have selected effect 2");
        }
    }

}