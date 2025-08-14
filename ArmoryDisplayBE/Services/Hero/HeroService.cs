using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Hero
{
    public class HeroService : IHeroService
    {
        private readonly DataContext dataContext;

        public HeroService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Hero> CreteHero(Models.Hero hero)
        {
            dataContext.Heroes.Add(hero);
            await dataContext.SaveChangesAsync();

            return hero;
        }

        public async Task<Models.Hero?> DeleteHero(int id)
        {
            var hero = await dataContext.Heroes.FindAsync(id);

            if (hero is null)
                return null;

            dataContext.Heroes.Remove(hero);
            await dataContext.SaveChangesAsync();

            return hero;
        }

        public async Task<List<Models.Hero>> GetAllHeros()
        {
            return await dataContext.Heroes.ToListAsync();
        }

        public async Task<Models.Hero?> GetSingleHero(int id)
        {
            var hero = await dataContext.Heroes.FindAsync(id);

            if (hero is null)
                return null;

            return hero;
        }

        public async Task<Models.Hero?> UpdateHero(int id, Models.Hero request)
        {
            var hero = await dataContext.Heroes.FindAsync(id);

            if (hero is null)
                return null;

            hero.ClassId = request.ClassId;
            hero.ConstellationId = request.ConstellationId;
            hero.ElementId = request.ElementId;
            hero.Name = request.Name;
            hero.RarityId = request.RarityId;

            await dataContext.SaveChangesAsync();

            return hero;
        }
    }
}
