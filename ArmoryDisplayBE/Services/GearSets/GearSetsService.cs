using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.GearSets
{
    public class GearSetsService : IGearSetsService
    {
        private readonly DataContext dataContext;

        public GearSetsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.GearSets> CreateGearSets(Models.GearSets gearSet)
        {
            dataContext.GearSets.Add(gearSet);

            await dataContext.SaveChangesAsync();

            return gearSet;
        }

        public async Task<Models.GearSets?> DeleteGearSets(int id)
        {
            var gearSet = await dataContext.GearSets.FindAsync(id);

            if (gearSet is null)
                return null;

            dataContext.GearSets.Remove(gearSet);

            await dataContext.SaveChangesAsync();

            return gearSet;
        }

        public async Task<List<Models.GearSets>> GetAllGearSets()
        {
            return await dataContext.GearSets.ToListAsync();
        }

        public async Task<Models.GearSets?> GetSingleGearSets(int id)
        {
            var gearSet = await dataContext.GearSets.FindAsync(id);

            if (gearSet is null)
                return null;

            return gearSet;
        }

        public async Task<Models.GearSets?> UpdateGearSets(int id, Models.GearSets request)
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
