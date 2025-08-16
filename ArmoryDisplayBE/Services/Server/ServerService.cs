using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Server
{
    public class ServerService : IServerService
    {
        private readonly DataContext dataContext;

        public ServerService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Server> CreateServer(Models.Server server)
        {
            dataContext.Servers.Add(server);
            await dataContext.SaveChangesAsync();

            return server;
        }

        public async Task<Models.Server?> DeleteServer(int id)
        {
            var server = await dataContext.Servers.FindAsync(id);

            if (server is null)
                return null;

            dataContext.Servers.Remove(server);
            await dataContext.SaveChangesAsync();

            return server;
        }

        public async Task<List<Models.Server>> GetAllServers()
        {
            return await dataContext.Servers.ToListAsync();
        }

        public async Task<Models.Server?> GetSingleServer(int id)
        {
            var server = await dataContext.Servers.FindAsync(id);

            if (server is null)
                return null;

            return server;
        }

        public async Task<Models.Server?> UpdateServer(int id, Models.Server request)
        {
            var server = await dataContext.Servers.FindAsync(id);

            if (server is null)
                return null;

            server.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return server;
        }
    }
}
