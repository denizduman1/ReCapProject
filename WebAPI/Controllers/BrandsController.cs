using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAll")]
        public ObjectResult GetAll()
        {
            var brandResult = _brandService.GetAll();
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }

        [HttpGet("GetById/{brandId:int}")]
        public ObjectResult GetById(int brandId)
        {
            var brandResult = _brandService.Get(brandId);
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }

        //object parametreli halini incele
        [HttpPost("GetByIdWithPost")]
        public ObjectResult GetByIdWithPost(int brandId)
        {    
            var brandResult = _brandService.Get(brandId);
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }

        [HttpPost("Add")]
        public ObjectResult Add(Brand brand)
        {
            var brandResult = _brandService.Add(brand);
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }

        [HttpPut("Update")]
        public ObjectResult Update(Brand brand)
        {
            var brandResult = _brandService.Update(brand);
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }

        [HttpDelete("Delete")]
        public ObjectResult Delete(Brand brand)
        {
            var brandResult = _brandService.Delete(brand);
            if (brandResult.IsSuccess)
            {
                return Ok(brandResult);
            }
            return BadRequest(brandResult);
        }
    }
}
