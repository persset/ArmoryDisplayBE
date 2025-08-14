using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Constellation
{
    public class ConstellationService : IConstellationService
    {
        private readonly DataContext dataContext;

        public ConstellationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Constellation> CreteConstellation(
            Models.Constellation constellation
        )
        {
            dataContext.Constellations.Add(constellation);
            await dataContext.SaveChangesAsync();

            return constellation;
        }

        public async Task<Models.Constellation?> DeleteConstellation(int id)
        {
            var constellation = await dataContext.Constellations.FindAsync(id);

            if (constellation is null)
                return null;

            dataContext.Constellations.Remove(constellation);
            await dataContext.SaveChangesAsync();

            return constellation;
        }

        public async Task<List<Models.Constellation>> GetAllConstellations()
        {
            return await dataContext.Constellations.ToListAsync();
        }

        public async Task<Models.Constellation?> GetSingleConstellation(int id)
        {
            var constellation = await dataContext.Constellations.FindAsync(id);

            if (constellation is null)
                return null;

            return constellation;
        }

        public async Task<Models.Constellation?> UpdateConstellation(
            int id,
            Models.Constellation request
        )
        {
            var constellation = await dataContext.Constellations.FindAsync(id);

            if (constellation is null)
                return null;

            constellation.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return constellation;
        }
    }
}
