using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.HeroBaseStats;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroBaseStatsController : ControllerBase
    {
        private readonly IHeroBaseStatsService heroBaseStatsService;

        public HeroBaseStatsController(IHeroBaseStatsService heroBaseStatsService)
        {
            this.heroBaseStatsService = heroBaseStatsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<HeroBaseStats>>> GetAllHeroBaseStats()
        {
            return await heroBaseStatsService.GetAllHeroBaseStats();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HeroBaseStats?>> GetSingleHeroBaseStats(int id)
        {
            var result = await heroBaseStatsService.GetSingleHeroBaseStats(id);

            if (result is null)
                return NotFound("Hero base stats not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<HeroBaseStats>> CreateHeroBaseStats(
            HeroBaseStats heroBaseStats
        )
        {
            var result = await heroBaseStatsService.CreateHeroBaseStats(heroBaseStats);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<HeroBaseStats>> UpdateHeroBaseStats(
            int id,
            HeroBaseStats heroBaseStats
        )
        {
            var result = await heroBaseStatsService.UpdateHeroBaseStats(id, heroBaseStats);

            if (result is null)
                return NotFound("Hero base stats not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHeroBaseStats(int id)
        {
            var result = await heroBaseStatsService.DeleteHeroBaseStats(id);

            if (result is null)
                return NotFound("Hero base stats not found");

            return Ok(result);
        }
    }
}
