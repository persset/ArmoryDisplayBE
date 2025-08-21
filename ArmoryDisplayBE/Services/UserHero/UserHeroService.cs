using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.UserHero
{
    public class UserHeroService : IUserHeroService
    {
        private readonly DataContext dataContext;

        public UserHeroService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.UserHero> CreateUserHero(Models.UserHero userHero)
        {
            dataContext.UserHeroes.Add(userHero);

            await dataContext.SaveChangesAsync();

            return userHero;
        }

        public async Task<Models.UserHero?> DeleteUserHero(int id)
        {
            var userHero = await dataContext.UserHeroes.FindAsync(id);

            if (userHero is null)
                return null;

            dataContext.UserHeroes.Remove(userHero);
            await dataContext.SaveChangesAsync();

            return userHero;
        }

        public async Task<List<Models.UserHero>> GetAllUserHeros()
        {
            return await dataContext.UserHeroes.ToListAsync();
        }

        public async Task<Models.UserHero?> GetSingleUserHero(int id)
        {
            var userHero = await dataContext.UserHeroes.FindAsync(id);

            if (userHero is null)
                return null;

            return userHero;
        }

        public async Task<Models.UserHero?> UpdateUserHero(int id, Models.UserHero request)
        {
            var userHero = await dataContext.UserHeroes.FindAsync(id);

            if (userHero is null)
                return null;

            userHero.Attack = request.Attack;
            userHero.CriticalHitChance = request.CriticalHitChance;
            userHero.CriticalHitDamage = request.CriticalHitDamage;
            userHero.Defense = request.Defense;
            userHero.DualAttackChance = request.DualAttackChance;
            userHero.Effectiveness = request.Effectiveness;
            userHero.EffectResistance = request.EffectResistance;
            userHero.Health = request.Health;
            userHero.HeroId = request.HeroId;
            userHero.Speed = request.Speed;
            userHero.UserId = request.UserId;

            await dataContext.SaveChangesAsync();

            return userHero;
        }
    }
}
