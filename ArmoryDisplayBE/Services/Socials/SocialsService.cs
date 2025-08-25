using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Socials
{
    public class SocialsService : ISocialsService
    {
        private readonly DataContext dataContext;

        public SocialsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Socials> CreateSocials(Models.Socials socials)
        {
            dataContext.Socials.Add(socials);

            await dataContext.SaveChangesAsync();

            return socials;
        }

        public async Task<Models.Socials?> DeleteSocials(int id)
        {
            var socials = await dataContext.Socials.FindAsync(id);

            if (socials is null)
                return null;

            dataContext.Socials.Remove(socials);

            await dataContext.SaveChangesAsync();

            return socials;
        }

        public async Task<List<Models.Socials>> GetAllSocials()
        {
            return await dataContext.Socials.ToListAsync();
        }

        public async Task<Models.Socials?> GetSingleSocials(int id)
        {
            var socials = await dataContext.Socials.FindAsync(id);

            if (socials is null)
                return null;

            return socials;
        }

        public async Task<Models.Socials?> UpdateSocials(int id, Models.Socials request)
        {
            var socials = await dataContext.Socials.FindAsync(id);

            if (socials is null)
                return null;

            socials.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return socials;
        }
    }
}
