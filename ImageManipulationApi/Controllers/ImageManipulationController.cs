using Application.Contract.Infrastructure.Effects;
using Application.Contract.Infrastructure.Resizes;
using Microsoft.AspNetCore.Mvc;

namespace ImageManipulationApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ImageManipulationController : ControllerBase
    {
        #region Fields

        private readonly IImageResize imageResize;
        private readonly IImageEffect1 imageEffect1;
        private readonly IImageEffect2 imageEffect2;
        private readonly IImageEffect3 imageEffect3;

        #endregion Fields

        #region Constructor

        public ImageManipulationController
        (
            IImageResize imageResize,
            IImageEffect1 imageEffect1,
            IImageEffect2 imageEffect2,
            IImageEffect3 imageEffect3
        )
        {
            this.imageResize = imageResize;
            this.imageEffect1 = imageEffect1;
            this.imageEffect2 = imageEffect2;
            this.imageEffect3 = imageEffect3;
        }

        #endregion Constructor

        #region Methods

        [HttpGet("ResizeImage")]
        public IActionResult ResizeImage(int size)
        {
            imageResize.ResizeImage( size );
            return Ok();
        }

        [HttpGet("UseEffect1")]
        public IActionResult UseEffect1()
        {
            imageEffect1.UseEffect();
            return Ok();
        }

        [HttpGet("UseEffect2")]
        public IActionResult UseEffect2()
        {
            imageEffect2.UseEffect();
            return Ok();
        }

        [HttpGet("UseEffect3")]
        public IActionResult UseEffect3()
        {
            imageEffect3.UseEffect();
            return Ok();
        }
        #endregion Methods

    }
}
