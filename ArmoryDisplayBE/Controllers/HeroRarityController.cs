using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.HeroRarity;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroRarityController : ControllerBase
    {
        private readonly IHeroRarityService heroRarityService;

        public HeroRarityController(IHeroRarityService heroRarityService)
        {
            this.heroRarityService = heroRarityService;
        }

        [HttpGet]
        public async Task<ActionResult<List<HeroRarity>>> GetAllHeroRarities()
        {
            return await heroRarityService.GetAllHeroRarities();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HeroRarity?>> GetSingleHeroRarity(int id)
        {
            var result = await heroRarityService.GetSingleHeroRarity(id);

            if (result is null)
                return NotFound("Hero rarity not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<HeroRarity>> CreateHeroRarity(HeroRarity heroRarity)
        {
            var result = await heroRarityService.CreateHeroRarity(heroRarity);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<HeroRarity>> UpdateHeroRarity(int id, HeroRarity heroRarity)
        {
            var result = await heroRarityService.UpdateHeroRarity(id, heroRarity);

            if (result is null)
                return NotFound("Hero rarity not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHeroRarity(int id)
        {
            var result = await heroRarityService.DeleteHeroRarity(id);

            if (result is null)
                return NotFound("Hero rarity not found");

            return Ok(result);
        }
    }
}
