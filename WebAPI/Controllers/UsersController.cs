using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService; 
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var userResult = _userService.GetAll();
            if (userResult.IsSuccess)
            {
                return Ok(userResult);
            }
            return BadRequest(userResult);
        }

        [HttpGet("GetById/{userId:int}")]
        public IActionResult GetById(int userId)
        {
            var userResult = _userService.GetbyId(userId);
            if (userResult.IsSuccess)
            {
                return Ok(userResult);
            }
            return BadRequest(userResult);
        }

        [HttpPost("Add")]
        public IActionResult Add(Core.Entities.Concrete.User user)
        {
            var userResult = _userService.Add(user);
            if (userResult.IsSuccess)
            {
                return Ok(userResult);
            }
            return BadRequest(userResult);
        }
    }
}
