using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Element;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        private readonly IElementService elementService;

        public ElementController(IElementService elementService)
        {
            this.elementService = elementService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Element>>> GetAllElements()
        {
            return await elementService.GetAllElements();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Element?>> GetSingleElement(int id)
        {
            var result = await elementService.GetSingleElement(id);

            if (result is null)
                return NotFound("Element not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Element>> CreateElement(Element element)
        {
            var result = await elementService.CreateElement(element);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Element>> UpdateElement(int id, Element element)
        {
            var result = await elementService.UpdateElement(id, element);

            if (result is null)
                return NotFound("Element not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteElement(int id)
        {
            var result = await elementService.DeleteElement(id);

            if (result is null)
                return NotFound("Element not found");

            return Ok("Element deleted successfully");
        }
    }
}
