using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Socials;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialsController : ControllerBase
    {
        private readonly ISocialsService socialsService;

        public SocialsController(ISocialsService socialsService)
        {
            this.socialsService = socialsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Socials>>> GetAllSocials()
        {
            return await socialsService.GetAllSocials();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Socials?>> GetSingleSocials(int id)
        {
            var result = await socialsService.GetSingleSocials(id);

            if (result is null)
                return NotFound("Socials not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Socials>> CreateSocials(Socials socials)
        {
            var result = await socialsService.CreateSocials(socials);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Socials>> UpdateSocials(int id, Socials socials)
        {
            var result = await socialsService.UpdateSocials(id, socials);

            if (result is null)
                return NotFound("Socials not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSocials(int id)
        {
            var result = await socialsService.DeleteSocials(id);

            if (result is null)
                return NotFound("Socials not found");

            return Ok("Socials deleted successfully");
        }
    }
}
