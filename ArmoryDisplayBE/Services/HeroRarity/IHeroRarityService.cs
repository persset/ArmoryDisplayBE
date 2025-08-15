namespace ArmoryDisplayBE.Services.HeroRarity
{
    public interface IHeroRarityService
    {
        Task<List<Models.HeroRarity>> GetAllHeroRarities();
        Task<Models.HeroRarity?> GetSingleHeroRarity(int id);
        Task<Models.HeroRarity> CreateHeroRarity(Models.HeroRarity heroRarity);
        Task<Models.HeroRarity?> UpdateHeroRarity(int id, Models.HeroRarity request);
        Task<Models.HeroRarity?> DeleteHeroRarity(int id);
    }
}
