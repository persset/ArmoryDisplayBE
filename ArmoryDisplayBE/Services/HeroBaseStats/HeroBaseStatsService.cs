using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.HeroBaseStats
{
    public class HeroBaseStatsService : IHeroBaseStatsService
    {
        private readonly DataContext dataContext;

        public HeroBaseStatsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.HeroBaseStats> CreateHeroBaseStats(
            Models.HeroBaseStats heroBaseStats
        )
        {
            dataContext.HeroBaseStats.Add(heroBaseStats);
            await dataContext.SaveChangesAsync();

            return heroBaseStats;
        }

        public async Task<Models.HeroBaseStats?> DeleteHeroBaseStats(int id)
        {
            var heroBaseStats = await dataContext.HeroBaseStats.FindAsync(id);

            if (heroBaseStats is null)
                return null;

            dataContext.HeroBaseStats.Remove(heroBaseStats);
            await dataContext.SaveChangesAsync();

            return heroBaseStats;
        }

        public async Task<List<Models.HeroBaseStats>> GetAllHeroBaseStats()
        {
            return await dataContext.HeroBaseStats.ToListAsync();
        }

        public async Task<Models.HeroBaseStats?> GetSingleHeroBaseStats(int id)
        {
            var heroBaseStats = await dataContext.HeroBaseStats.FindAsync(id);

            if (heroBaseStats is null)
                return null;

            return heroBaseStats;
        }

        public async Task<Models.HeroBaseStats?> UpdateHeroBaseStats(
            int id,
            Models.HeroBaseStats request
        )
        {
            var heroBaseStats = await dataContext.HeroBaseStats.FindAsync(id);

            if (heroBaseStats is null)
                return null;

            heroBaseStats.Attack = request.Attack;
            heroBaseStats.HeroClassId = request.HeroClassId;
            heroBaseStats.ConstellationId = request.ConstellationId;
            heroBaseStats.CriticalHitChance = request.CriticalHitChance;
            heroBaseStats.CriticalHitDamage = request.CriticalHitDamage;
            heroBaseStats.Defense = request.Defense;
            heroBaseStats.DualAttackChance = request.DualAttackChance;
            heroBaseStats.Effectiveness = request.Effectiveness;
            heroBaseStats.EffectResistance = request.EffectResistance;
            heroBaseStats.Health = request.Health;
            heroBaseStats.HeroRarityId = request.HeroRarityId;
            heroBaseStats.Speed = request.Speed;

            await dataContext.SaveChangesAsync();

            return heroBaseStats;
        }
    }
}
