using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.UserSocials;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSocialsController : ControllerBase
    {
        private readonly IUserSocialsService userSocialsService;

        public UserSocialsController(IUserSocialsService userSocialsService)
        {
            this.userSocialsService = userSocialsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserSocials>>> GetAllUserSocials()
        {
            return await userSocialsService.GetAllUserSocials();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserSocials?>> GetSingleUserSocials(int id)
        {
            var result = await userSocialsService.GetSingleUserSocials(id);

            if (result is null)
                return NotFound("User Socials not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<UserSocials>> CreateUserSocials(UserSocials userSocials)
        {
            var result = await userSocialsService.CreateUserSocials(userSocials);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserSocials?>> UpdateUserSocials(
            int id,
            UserSocials userSocials
        )
        {
            var result = await userSocialsService.UpdateUserSocials(id, userSocials);

            if (result is null)
                return NotFound("User Socials not found to update.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserSocials(int id)
        {
            var result = await userSocialsService.DeleteUserSocials(id);

            if (result is null)
                return NotFound("User Socials not found to delete.");

            return Ok(result);
        }
    }
}
