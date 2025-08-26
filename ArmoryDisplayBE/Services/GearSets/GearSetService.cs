using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.GearSet
{
    public class GearSetService : IGearSetService
    {
        private readonly DataContext dataContext;

        public GearSetService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.GearSet> CreateGearSet(Models.GearSet gearSet)
        {
            dataContext.GearSets.Add(gearSet);

            await dataContext.SaveChangesAsync();

            return gearSet;
        }

        public async Task<Models.GearSet?> DeleteGearSet(int id)
        {
            var gearSet = await dataContext.GearSets.FindAsync(id);

            if (gearSet is null)
                return null;

            dataContext.GearSets.Remove(gearSet);

            await dataContext.SaveChangesAsync();

            return gearSet;
        }

        public async Task<List<Models.GearSet>> GetAllGearSets()
        {
            return await dataContext.GearSets.ToListAsync();
        }

        public async Task<Models.GearSet?> GetSingleGearSet(int id)
        {
            var gearSet = await dataContext.GearSets.FindAsync(id);

            if (gearSet is null)
                return null;

            return gearSet;
        }

        public async Task<Models.GearSet?> UpdateGearSet(int id, Models.GearSet request)
        {
            var gearSet = await dataContext.GearSets.FindAsync(id);

            if (gearSet is null)
                return null;

            gearSet.BonusStatsId = request.BonusStatsId;
            gearSet.BonusStatsValue = request.BonusStatsValue;
            gearSet.IsTwoPiece = request.IsTwoPiece;
            gearSet.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return gearSet;
        }
    }
}
