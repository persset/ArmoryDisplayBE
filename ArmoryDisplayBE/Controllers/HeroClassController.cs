using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.HeroClass;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroClassController : ControllerBase
    {
        private readonly IHeroClassService heroClassService;

        public HeroClassController(IHeroClassService heroClassService)
        {
            this.heroClassService = heroClassService;
        }

        [HttpGet]
        public async Task<ActionResult<List<HeroClass>>> GetAllHeroClasses()
        {
            return await heroClassService.GetAllHeroClasses();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HeroClass?>> GetSingleHeroClass(int id)
        {
            var result = await heroClassService.GetSingleHeroClass(id);

            if (result is null)
                return NotFound("Hero class not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<HeroClass>> CreateHeroClass(HeroClass heroClass)
        {
            var result = await heroClassService.CreateHeroClass(heroClass);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<HeroClass>> UpdateHeroClass(int id, HeroClass heroClass)
        {
            var result = await heroClassService.UpdateHeroClass(id, heroClass);

            if (result is null)
                return NotFound("Hero class not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHeroClass(int id)
        {
            var result = await heroClassService.DeleteHeroClass(id);

            if (result is null)
                return NotFound("Hero class not found");

            return Ok(result);
        }
    }
}
