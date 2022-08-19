using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("GetAll")]
        public ObjectResult GetAll()
        {
            var rentalResult = _rentalService.GetAll();

            if (rentalResult.IsSuccess)
            {
                return Ok(rentalResult);
            }
            return BadRequest(rentalResult);
        }

        [HttpGet("GetById/{rentalId:int}")]
        public ObjectResult GetById(int rentalId)
        {
            var rentalResult = _rentalService.GetbyId(rentalId);

            if (rentalResult.IsSuccess)
            {
                return Ok(rentalResult);
            }
            return BadRequest(rentalResult);
        }

        [HttpPost("Add")]
        public ObjectResult Add(Rental rental)
        {
            var rentalResult = _rentalService.Add(rental);

            if (rentalResult.IsSuccess)
            {
                return Ok(rentalResult);
            }
            return BadRequest(rentalResult);
        }

    }
}
