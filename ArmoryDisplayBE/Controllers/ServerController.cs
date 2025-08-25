using ArmoryDisplayBE.Models;
using ArmoryDisplayBE.Services.Server;
using Microsoft.AspNetCore.Mvc;

namespace ArmoryDisplayBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly IServerService serverService;

        public ServerController(IServerService serverService)
        {
            this.serverService = serverService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Server>>> GetAllServers()
        {
            return await serverService.GetAllServers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Server?>> GetSingleServer(int id)
        {
            var result = await serverService.GetSingleServer(id);

            if (result is null)
                return NotFound("Server not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Server>> CreateServer(Server server)
        {
            var result = await serverService.CreateServer(server);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Server>> UpdateServer(int id, Server server)
        {
            var result = await serverService.UpdateServer(id, server);

            if (result is null)
                return NotFound("Server not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteServer(int id)
        {
            var result = await serverService.DeleteServer(id);

            if (result is null)
                return NotFound("Server not found");

            return Ok(result);
        }
    }
}
