using ArmoryDisplayBE.Data;
using ArmoryDisplayBE.Services.Stats;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Stat
{
    public class StatService : IStatsService
    {
        private readonly DataContext dataContext;

        public StatService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Stat> CreateStat(Models.Stat stat)
        {
            dataContext.Stats.Add(stat);

            await dataContext.SaveChangesAsync();

            return stat;
        }

        public async Task<Models.Stat?> DeleteStat(int id)
        {
            var stat = await dataContext.Stats.FindAsync(id);

            if (stat is null)
                return null;

            dataContext.Stats.Remove(stat);

            await dataContext.SaveChangesAsync();

            return stat;
        }

        public async Task<List<Models.Stat>> GetAllStats()
        {
            return await dataContext.Stats.ToListAsync();
        }

        public async Task<Models.Stat?> GetSingleStat(int id)
        {
            var stat = await dataContext.Stats.FindAsync(id);

            if (stat is null)
                return null;

            return stat;
        }

        public async Task<Models.Stat?> UpdateStat(int id, Models.Stat request)
        {
            var stat = await dataContext.Stats.FindAsync(id);

            if (stat is null)
                return null;

            stat.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return stat;
        }
    }
}
