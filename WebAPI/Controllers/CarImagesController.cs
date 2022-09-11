using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;
        private IWebHostEnvironment _webhostEnvironment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webhostEnvironment)
        {
            _carImageService = carImageService;
            _webhostEnvironment = webhostEnvironment;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromForm] CarImageAddDto carImageAddDto)
        {
            var wwwroot = _webhostEnvironment.WebRootPath;
            var res = _carImageService.Add(carImageAddDto, wwwroot);

            if (res.IsSuccess)
            {
                return Ok(res);
            }

            return BadRequest(res.Message);
        }

        [HttpDelete]
        public IActionResult Delete(CarImageDeleteDto carImageDeleteDto)
        {
            var wwwroot = _webhostEnvironment.WebRootPath;
            var res = _carImageService.Delete(carImageDeleteDto, wwwroot);

            if (res.IsSuccess)
            {            
                return Ok(res);
            }

            return BadRequest(res.Message);
        }

        [HttpPut]
        public IActionResult Update([FromForm] CarImageUpdateDto carImageUpdateDto)
        {
            var wwwroot = _webhostEnvironment.WebRootPath;
            var res = _carImageService.Update(carImageUpdateDto, wwwroot);

            if (res.IsSuccess)
            {
                return Ok(res);
            }

            return BadRequest(res.Message);
        }

        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var carImageResult = _carImageService.GetAll();
            if (carImageResult.IsSuccess)
            {
                return Ok(carImageResult);
            }
            return BadRequest(carImageResult);
        }

        [HttpGet("GetAll/{carId:int}")]
        public IActionResult GetByCarId(int carId)
        {
            var carImageResult = _carImageService.GetbyCarId(carId);
            if (carImageResult.IsSuccess)
            {
                return Ok(carImageResult);
            }
            return BadRequest(carImageResult);
        }

    }
}
