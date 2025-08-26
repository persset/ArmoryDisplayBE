using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.services.UserHeroGearStats
{
    public class UserHeroGearStats : IUserHeroGearStats
    {
        private readonly DataContext dataContext;

        public UserHeroGearStats(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.UserHeroGearStats> CreateUserHeroGearStats(
            Models.UserHeroGearStats userHeroGearStats
        )
        {
            dataContext.UserHeroGearStats.Add(userHeroGearStats);

            await dataContext.SaveChangesAsync();

            return userHeroGearStats;
        }

        public async Task<Models.UserHeroGearStats?> DeleteUserHeroGearStats(int id)
        {
            var userHeroGearStats = await dataContext.UserHeroGearStats.FindAsync(id);

            if (userHeroGearStats is null)
                return null;

            dataContext.UserHeroGearStats.Remove(userHeroGearStats);

            await dataContext.SaveChangesAsync();

            return userHeroGearStats;
        }

        public async Task<List<Models.UserHeroGearStats>> GetAllUserHeroGearStats()
        {
            return await dataContext.UserHeroGearStats.ToListAsync();
        }

        public async Task<Models.UserHeroGearStats?> GetSingleUserHeroGearStats(int id)
        {
            var userHeroGearStats = await dataContext.UserHeroGearStats.FindAsync(id);

            if (userHeroGearStats is null)
                return null;

            return userHeroGearStats;
        }

        public async Task<Models.UserHeroGearStats?> UpdateUserHeroGearStats(
            int id,
            Models.UserHeroGearStats request
        )
        {
            var userHeroGearStats = await dataContext.UserHeroGearStats.FindAsync(id);

            if (userHeroGearStats is null)
                return null;
            userHeroGearStats.GearStatsId = request.GearStatsId;
            userHeroGearStats.UserHeroGearId = request.UserHeroGearId;
            userHeroGearStats.Value = request.Value;
            userHeroGearStats.IsMainStat = request.IsMainStat;
            userHeroGearStats.IsPercent = request.IsPercent;

            await dataContext.SaveChangesAsync();

            return userHeroGearStats;
        }
    }
}
