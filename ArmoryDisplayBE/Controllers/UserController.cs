using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetSingleUser(int id)
        {
            var user = await userService.GetSingleUser(id);

            if (user is null)
            {
                return NotFound("User not found.");
            }

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            var result = await userService.CreateUser(user);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User user)
        {
            var result = await userService.UpdateUser(id, user);

            if (result is null)
            {
                return NotFound("User not found to update.");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var result = await userService.DeleteUser(id);

            if (result is null)
            {
                return NotFound("No user found to delete.");
            }

            return Ok(result);
        }
    }
}
