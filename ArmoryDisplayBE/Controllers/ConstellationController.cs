using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Constellation;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstellationController : ControllerBase
    {
        private readonly IConstellationService constellationService;

        public ConstellationController(IConstellationService constellationService)
        {
            this.constellationService = constellationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Constellation>>> GetAllConstellations()
        {
            return await constellationService.GetAllConstellations();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Constellation?>> GetSingleConstellation(int id)
        {
            var result = await constellationService.GetSingleConstellation(id);

            if (result is null)
                return NotFound("Constellation not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Constellation>> CreateConstellation(
            Constellation constellation
        )
        {
            var result = await constellationService.CreateConstellation(constellation);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Constellation>> UpdateConstellation(
            int id,
            Constellation constellation
        )
        {
            var result = await constellationService.UpdateConstellation(id, constellation);

            if (result is null)
                return NotFound("Constellation not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConstellation(int id)
        {
            var result = await constellationService.DeleteConstellation(id);

            if (result is null)
                return NotFound("No constellation found to delete");

            return Ok(result);
        }
    }
}
