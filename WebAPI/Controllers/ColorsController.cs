using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("GetAll")]
        public ObjectResult GetAll()
        {
            var colorResult = _colorService.GetAll();
            if (colorResult.IsSuccess)
            {
                return Ok(colorResult);
            }
            return BadRequest(colorResult);
        }

        [HttpGet("GetById/{colorId:int}")]
        public ObjectResult GetById(int colorId)
        {
            var colorResult = _colorService.Get(colorId);
            if (colorResult.IsSuccess)
            {
                return Ok(colorResult);
            }
            return BadRequest(colorResult);
        }

        [HttpPost("Add")]
        public ObjectResult Add(Color color)
        {
            var colorResult = _colorService.Add(color);
            if (colorResult.IsSuccess)
            {
                return Ok(colorResult);
            }
            return BadRequest(colorResult);
        }

        [HttpPut("Update")]
        public ObjectResult Update(Color color)
        {
            var colorResult = _colorService.Update(color);
            if (colorResult.IsSuccess)
            {
                return Ok(colorResult);
            }
            return BadRequest(colorResult);
        }

        [HttpDelete("Delete")]
        public ObjectResult Delete(Color color)
        {
            var colorResult = _colorService.Delete(color);
            if (colorResult.IsSuccess)
            {
                return Ok(colorResult);
            }
            return BadRequest(colorResult);
        }

    }
}
