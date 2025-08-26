using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.GearType
{
    public class GearTypeService : IGearTypeService
    {
        private readonly DataContext dataContext;

        public GearTypeService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.GearType> CreateGearTypes(Models.GearType gearType)
        {
            dataContext.GearTypes.Add(gearType);

            await dataContext.SaveChangesAsync();

            return gearType;
        }

        public async Task<Models.GearType?> DeleteGearType(int id)
        {
            var gearType = await dataContext.GearTypes.FindAsync(id);

            if (gearType is null)
                return null;

            dataContext.GearTypes.Remove(gearType);

            await dataContext.SaveChangesAsync();

            return gearType;
        }

        public async Task<List<Models.GearType>> GetAllGearType()
        {
            return await dataContext.GearTypes.ToListAsync();
        }

        public async Task<Models.GearType?> GetSingleGearType(int id)
        {
            var gearType = await dataContext.GearTypes.FindAsync(id);

            if (gearType is null)
                return null;

            return gearType;
        }

        public async Task<Models.GearType?> UpdateGearType(int id, Models.GearType request)
        {
            var gearType = await dataContext.GearTypes.FindAsync(id);

            if (gearType is null)
                return null;

            gearType.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return gearType;
        }
    }
}
