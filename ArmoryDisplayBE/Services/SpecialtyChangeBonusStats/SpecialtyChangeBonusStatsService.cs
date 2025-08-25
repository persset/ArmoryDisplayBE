using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.SpecialtyChangeBonusStats
{
    public class SpecialtyChangeBonusStatsService : ISpecialtyChangeBonusStatsService
    {
        private readonly DataContext dataContext;

        public SpecialtyChangeBonusStatsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.SpecialtyChangeBonusStats> CreateSpecialtyChangeBonusStats(
            Models.SpecialtyChangeBonusStats specialtyChangeBonus
        )
        {
            dataContext.SpecialtyChangeBonusStats.Add(specialtyChangeBonus);

            await dataContext.SaveChangesAsync();

            return specialtyChangeBonus;
        }

        public async Task<Models.SpecialtyChangeBonusStats?> DeleteSpecialtyChangeBonusStats(int id)
        {
            var specialtyChangeBonus = await dataContext.SpecialtyChangeBonusStats.FindAsync(id);

            if (specialtyChangeBonus is null)
                return null;

            dataContext.SpecialtyChangeBonusStats.Remove(specialtyChangeBonus);

            await dataContext.SaveChangesAsync();

            return specialtyChangeBonus;
        }

        public async Task<List<Models.SpecialtyChangeBonusStats>> GetAllSpecialtyChangeBonusStats()
        {
            return await dataContext.SpecialtyChangeBonusStats.ToListAsync();
        }

        public async Task<Models.SpecialtyChangeBonusStats?> GetSingleSpecialtyChangeBonusStats(
            int id
        )
        {
            var specialtyChangeBonus = await dataContext.SpecialtyChangeBonusStats.FindAsync(id);

            if (specialtyChangeBonus is null)
                return null;

            return specialtyChangeBonus;
        }

        public async Task<Models.SpecialtyChangeBonusStats?> UpdateSpecialtyChangeBonusStats(
            int id,
            Models.SpecialtyChangeBonusStats request
        )
        {
            var specialtyChangeBonus = await dataContext.SpecialtyChangeBonusStats.FindAsync(id);

            if (specialtyChangeBonus is null)
                return null;

            specialtyChangeBonus.Attack = request.Attack;
            specialtyChangeBonus.CriticalHitChance = request.CriticalHitChance;
            specialtyChangeBonus.CriticalHitDamage = request.CriticalHitDamage;
            specialtyChangeBonus.Defense = request.Defense;
            specialtyChangeBonus.DualAttackChance = request.DualAttackChance;
            specialtyChangeBonus.Effectiveness = request.Effectiveness;
            specialtyChangeBonus.EffectResistance = request.EffectResistance;
            specialtyChangeBonus.Health = request.Health;
            specialtyChangeBonus.HeroId = request.HeroId;
            specialtyChangeBonus.Speed = request.Speed;

            await dataContext.SaveChangesAsync();

            return specialtyChangeBonus;
        }
    }
}
