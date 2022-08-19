using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;   
        }

        [HttpGet("GetAll")]
        public ObjectResult GetAll()
        {
            var carResult = _carService.GetAll();
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }

        [HttpGet("GetAllDetail")]
        public ObjectResult GetAllDetail()
        {
            var carResult = _carService.GetAllCarDetails();
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }

        [HttpGet("GetById/{carId:int}")]
        public ObjectResult GetById(int carId)
        {
            var carResult = _carService.Get(carId);
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }

        [HttpPost("Add")]
        public ObjectResult Add(Car car)
        {
            var carResult = _carService.Add(car);
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }

        [HttpPut("Update")]
        public ObjectResult Update(Car car)
        {
            var carResult = _carService.Update(car);
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }

        [HttpDelete("Delete")]
        public ObjectResult Delete(Car car)
        {
            var carResult = _carService.Delete(car);
            if (carResult.IsSuccess)
            {
                return Ok(carResult);
            }
            return BadRequest(carResult);
        }
    }
}
