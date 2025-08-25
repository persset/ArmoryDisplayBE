namespace ArmoryDisplayBE.Services.HeroBaseStats
{
    public interface IHeroBaseStatsService
    {
        Task<List<Models.HeroBaseStats>> GetAllHeroBaseStats();
        Task<Models.HeroBaseStats?> GetSingleHeroBaseStats(int id);
        Task<Models.HeroBaseStats> CreateHeroBaseStats(Models.HeroBaseStats heroBaseStats);
        Task<Models.HeroBaseStats?> UpdateHeroBaseStats(int id, Models.HeroBaseStats request);
        Task<Models.HeroBaseStats?> DeleteHeroBaseStats(int id);
    }
}
