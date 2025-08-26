using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.GearType;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearTypeController : ControllerBase
    {
        private readonly IGearTypeService gearTypeService;

        public GearTypeController(IGearTypeService gearTypeService)
        {
            this.gearTypeService = gearTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GearType>>> GetAllGearTypes()
        {
            return await gearTypeService.GetAllGearTypes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GearType>> GetSingleGearType(int id)
        {
            var gearType = await gearTypeService.GetSingleGearType(id);

            if (gearType is null)
                return NotFound("Gear Type not found.");

            return gearType;
        }

        [HttpPost]
        public async Task<ActionResult<List<GearType>>> CreateGearType(GearType request)
        {
            var gearType = await gearTypeService.CreateGearType(request);

            return Ok(gearType);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<GearType>>> UpdateGearType(int id, GearType request)
        {
            var gearType = await gearTypeService.UpdateGearType(id, request);

            if (gearType is null)
                return NotFound("Gear Type not found.");

            return Ok(gearType);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<GearType>>> DeleteGearType(int id)
        {
            var gearType = await gearTypeService.DeleteGearType(id);

            if (gearType is null)
                return NotFound("Gear Type not found.");

            return Ok(gearType);
        }
    }
}
