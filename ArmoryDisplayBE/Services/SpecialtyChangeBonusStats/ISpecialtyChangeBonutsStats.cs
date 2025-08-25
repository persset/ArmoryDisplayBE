namespace ArmoryDisplayBE.Services.SpecialtyChangeBonusStats
{
    public interface ISpecialtyChangeBonusStatsService
    {
        Task<List<Models.SpecialtyChangeBonusStats>> GetAllSpecialtyChangeBonusStats();
        Task<Models.SpecialtyChangeBonusStats?> GetSingleSpecialtyChangeBonusStats(int id);
        Task<Models.SpecialtyChangeBonusStats> CreateSpecialtyChangeBonusStats(
            Models.SpecialtyChangeBonusStats specialtyChangeBonus
        );
        Task<Models.SpecialtyChangeBonusStats?> UpdateSpecialtyChangeBonusStats(
            int id,
            Models.SpecialtyChangeBonusStats request
        );
        Task<Models.SpecialtyChangeBonusStats?> DeleteSpecialtyChangeBonusStats(int id);
    }
}
