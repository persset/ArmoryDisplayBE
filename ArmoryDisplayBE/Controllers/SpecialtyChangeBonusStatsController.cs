using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.SpecialtyChangeBonusStats;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyChangeBonusStatsController : ControllerBase
    {
        private readonly ISpecialtyChangeBonusStatsService specialtyChangeBonusStatsService;

        public SpecialtyChangeBonusStatsController(
            ISpecialtyChangeBonusStatsService specialtyChangeBonusStatsService
        )
        {
            this.specialtyChangeBonusStatsService = specialtyChangeBonusStatsService;
        }

        [HttpGet]
        public async Task<
            ActionResult<List<SpecialtyChangeBonusStats>>
        > GetAllSpecialtyChangeBonusStats()
        {
            return await specialtyChangeBonusStatsService.GetAllSpecialtyChangeBonusStats();
        }

        [HttpGet("{id}")]
        public async Task<
            ActionResult<SpecialtyChangeBonusStats?>
        > GetSingleSpecialtyChangeBonusStats(int id)
        {
            var result = await specialtyChangeBonusStatsService.GetSingleSpecialtyChangeBonusStats(
                id
            );

            if (result is null)
                return NotFound("Specialty change bonus stats not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SpecialtyChangeBonusStats>> CreateSpecialtyChangeBonusStats(
            SpecialtyChangeBonusStats specialtyChangeBonusStats
        )
        {
            var result = await specialtyChangeBonusStatsService.CreateSpecialtyChangeBonusStats(
                specialtyChangeBonusStats
            );

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SpecialtyChangeBonusStats>> UpdateSpecialtyChangeBonusStats(
            int id,
            SpecialtyChangeBonusStats specialtyChangeBonusStats
        )
        {
            var result = await specialtyChangeBonusStatsService.UpdateSpecialtyChangeBonusStats(
                id,
                specialtyChangeBonusStats
            );

            if (result is null)
                return NotFound("Specialty change bonus stats not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSpecialtyChangeBonusStats(int id)
        {
            var result = await specialtyChangeBonusStatsService.DeleteSpecialtyChangeBonusStats(id);

            if (result is null)
                return NotFound("Specialty change bonus stats not found");

            return Ok(result);
        }
    }
}
