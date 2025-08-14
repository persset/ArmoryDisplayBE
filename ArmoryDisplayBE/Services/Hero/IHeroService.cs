namespace ArmoryDisplayBE.Services.Hero
{
    public interface IHeroService
    {
        Task<List<Models.Hero>> GetAllHeros();
        Task<Models.Hero?> GetSingleHero(int id);
        Task<Models.Hero> CreteHero(Models.Hero hero);
        Task<Models.Hero?> UpdateHero(int id, Models.Hero request);
        Task<Models.Hero?> DeleteHero(int id);
    }
}
