using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.GearSet;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearSetController : ControllerBase
    {
        private readonly IGearSetService gearSetService;

        public GearSetController(IGearSetService gearSetService)
        {
            this.gearSetService = gearSetService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GearSet>>> GetAllGearSets()
        {
            return await gearSetService.GetAllGearSets();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GearSet>> GetSingleGearSet(int id)
        {
            var gearSet = await gearSetService.GetSingleGearSet(id);

            if (gearSet is null)
                return NotFound("Gear Set not found.");

            return gearSet;
        }

        [HttpPost]
        public async Task<ActionResult<List<GearSet>>> CreateGearSet(GearSet request)
        {
            var gearSet = await gearSetService.CreateGearSet(request);

            return Ok(gearSet);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<GearSet>>> UpdateGearSet(int id, GearSet request)
        {
            var gearSet = await gearSetService.UpdateGearSet(id, request);

            if (gearSet is null)
                return NotFound("Gear Set not found.");

            return Ok(gearSet);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<GearSet>>> DeleteGearSet(int id)
        {
            var gearSet = await gearSetService.DeleteGearSet(id);

            if (gearSet is null)
                return NotFound("Gear Set not found.");

            return Ok(gearSet);
        }
    }
}
