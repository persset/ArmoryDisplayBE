using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.HeroRarity
{
    public class HeroRarityService : IHeroRarityService
    {
        private readonly DataContext dataContext;

        public HeroRarityService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.HeroRarity> CreateHeroRarity(Models.HeroRarity heroRarity)
        {
            dataContext.HeroRarities.Add(heroRarity);

            await dataContext.SaveChangesAsync();

            return heroRarity;
        }

        public async Task<Models.HeroRarity?> DeleteHeroRarity(int id)
        {
            var heroRarity = await dataContext.HeroRarities.FindAsync(id);

            if (heroRarity is null)
                return null;

            dataContext.Remove(heroRarity);
            await dataContext.SaveChangesAsync();

            return heroRarity;
        }

        public async Task<List<Models.HeroRarity>> GetAllHeroRarities()
        {
            return await dataContext.HeroRarities.ToListAsync();
        }

        public async Task<Models.HeroRarity?> GetSingleHeroRarity(int id)
        {
            var heroRarity = await dataContext.HeroRarities.FindAsync(id);

            if (heroRarity is null)
                return null;

            return heroRarity;
        }

        public async Task<Models.HeroRarity?> UpdateHeroRarity(int id, Models.HeroRarity request)
        {
            var heroRarity = await dataContext.HeroRarities.FindAsync(id);

            if (heroRarity is null)
                return null;

            heroRarity.BaseStars = request.BaseStars;

            await dataContext.SaveChangesAsync();

            return heroRarity;
        }
    }
}
