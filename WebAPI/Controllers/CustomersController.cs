using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
                _customerService = customerService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ObjectResult GetAll()
        {
            var customerResult = _customerService.GetAll();
            if (customerResult.IsSuccess)
            {
                return Ok(customerResult);
            }
            return BadRequest(customerResult);
        }

        [HttpGet]
        [Route("GetById/{customerId:int}")]
        public ObjectResult GetById(int customerId)
        {
            var customerResult = _customerService.GetbyId(customerId);
            if (customerResult.IsSuccess)
            {
                return Ok(customerResult);
            }
            return BadRequest(customerResult);
        }

        [HttpPost]
        [Route("Add")]
        public ObjectResult Add(Customer customer)
        {
            var customerResult = _customerService.Add(customer);
            if (customerResult.IsSuccess)
            {
                return Ok(customerResult);
            }
            return BadRequest(customerResult);
        }
        
    }
}
