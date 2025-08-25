namespace ArmoryDisplayBE.Services.HeroClass
{
    public interface IHeroClassService
    {
        Task<List<Models.HeroClass>> GetAllHeroClasses();
        Task<Models.HeroClass?> GetSingleHeroClass(int id);
        Task<Models.HeroClass> CreateHeroClass(Models.HeroClass heroClass);
        Task<Models.HeroClass?> UpdateHeroClass(int id, Models.HeroClass request);
        Task<Models.HeroClass?> DeleteHeroClass(int id);
    }
}
