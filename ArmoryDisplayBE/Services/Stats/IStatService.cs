namespace ArmoryDisplayBE.Services.Stats
{
    public interface IStatsService
    {
        Task<List<Models.Stat>> GetAllStats();
        Task<Models.Stat?> GetSingleStat(int id);
        Task<Models.Stat> CreateStat(Models.Stat stat);
        Task<Models.Stat?> UpdateStat(int id, Models.Stat request);
        Task<Models.Stat?> DeleteStat(int id);
    }
}
