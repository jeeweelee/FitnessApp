using Fitness.Interfaces;
using Fitness.Model;
using Fitness.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {   
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
             _userService = userService;
        }
        [HttpGet("All")]
        public ActionResult<List<User>> GetAllUsers()
        {
            try
            {
                var users = _userService.getAllUser(); // Returns IQueryable<User>
                return Ok(users);// Convert to List before returning
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500,ex);
            }
        }
    }
}
