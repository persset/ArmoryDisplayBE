using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.UserHero;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserHeroController : ControllerBase
    {
        private readonly IUserHeroService userHeroService;

        public UserHeroController(IUserHeroService userHeroService)
        {
            this.userHeroService = userHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserHero>>> GetAllUserHeroes()
        {
            return await userHeroService.GetAllUserHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserHero?>> GetSingleUserHero(int id)
        {
            var result = await userHeroService.GetSingleUserHero(id);

            if (result is null)
                return NotFound("User Hero not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<UserHero>> CreateUserHero(UserHero userHero)
        {
            var result = await userHeroService.CreateUserHero(userHero);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserHero?>> UpdateUserHero(int id, UserHero userHero)
        {
            var result = await userHeroService.UpdateUserHero(id, userHero);

            if (result is null)
                return NotFound("User Hero not found to update.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserHero(int id)
        {
            var result = await userHeroService.DeleteUserHero(id);

            if (result is null)
                return NotFound("User Hero not found to delete.");

            return Ok("User Hero deleted successfully.");
        }
    }
}
