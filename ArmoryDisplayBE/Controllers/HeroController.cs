using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Hero;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService heroService;

        public HeroController(IHeroService heroService)
        {
            this.heroService = heroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetAllHeroes()
        {
            return await heroService.GetAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hero?>> GetSingleHero(int id)
        {
            var result = await heroService.GetSingleHero(id);

            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Hero>> CreateHero(Hero hero)
        {
            var result = await heroService.CreateHero(hero);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Hero>> UpdateHero(int id, Hero hero)
        {
            var result = await heroService.UpdateHero(id, hero);

            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHero(int id)
        {
            var result = await heroService.DeleteHero(id);

            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);
        }
    }
}
