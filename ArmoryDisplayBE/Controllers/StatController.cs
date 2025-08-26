using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Stat;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        private readonly IStatService statService;

        public StatController(IStatService statService)
        {
            this.statService = statService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stat>>> GetAllStats()
        {
            return await statService.GetAllStats();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stat>> GetSingleStat(int id)
        {
            var stat = await statService.GetSingleStat(id);

            if (stat is null)
                return NotFound("Stat not found.");

            return stat;
        }

        [HttpPost]
        public async Task<ActionResult<List<Stat>>> CreateStat(Stat request)
        {
            var stat = await statService.CreateStat(request);

            return Ok(stat);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Stat>>> UpdateStat(int id, Stat request)
        {
            var stat = await statService.UpdateStat(id, request);

            if (stat is null)
                return NotFound("Stat not found.");

            return Ok(stat);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Stat>>> DeleteStat(int id)
        {
            var stat = await statService.DeleteStat(id);

            if (stat is null)
                return NotFound("Stat not found.");

            return Ok(stat);
        }
    }
}
