using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.HeroClass
{
    public class HeroClassService : IHeroClassService
    {
        private readonly DataContext dataContext;

        public HeroClassService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.HeroClass> CreateHeroClass(Models.HeroClass heroClass)
        {
            dataContext.HeroClasses.Add(heroClass);
            await dataContext.SaveChangesAsync();

            return heroClass;
        }

        public async Task<Models.HeroClass?> DeleteHeroClass(int id)
        {
            var heroClass = await dataContext.HeroClasses.FindAsync(id);

            if (heroClass is null)
                return null;

            dataContext.HeroClasses.Remove(heroClass);

            return heroClass;
        }

        public async Task<List<Models.HeroClass>> GetAllHeroClasses()
        {
            return await dataContext.HeroClasses.ToListAsync();
        }

        public async Task<Models.HeroClass?> GetSingleHeroClass(int id)
        {
            var heroClass = await dataContext.HeroClasses.FindAsync(id);

            if (heroClass is null)
                return null;

            return heroClass;
        }

        public async Task<Models.HeroClass?> UpdateHeroClass(int id, Models.HeroClass request)
        {
            var heroClass = await dataContext.HeroClasses.FindAsync(id);

            if (heroClass is null)
                return null;

            heroClass.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return heroClass;
        }
    }
}
