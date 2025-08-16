namespace ArmoryDisplayBE.Services.Server
{
    public interface IServerService
    {
        Task<List<Models.Server>> GetAllServers();
        Task<Models.Server?> GetSingleServer(int id);
        Task<Models.Server> CreateServer(Models.Server server);
        Task<Models.Server?> UpdateServer(int id, Models.Server request);
        Task<Models.Server?> DeleteServer(int id);
    }
}
