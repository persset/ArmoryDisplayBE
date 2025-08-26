using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.services.UserHeroGear
{
    public class UserHeroGear : IUserHeroGear
    {
        private readonly Data.DataContext dataContext;

        public UserHeroGear(Data.DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.UserHeroGear> CreateUserHeroGear(Models.UserHeroGear userHeroGear)
        {
            dataContext.UserHeroGears.Add(userHeroGear);

            await dataContext.SaveChangesAsync();

            return userHeroGear;
        }

        public async Task<Models.UserHeroGear?> DeleteUserHeroGear(int id)
        {
            var userHeroGear = await dataContext.UserHeroGears.FindAsync(id);

            if (userHeroGear is null)
                return null;

            dataContext.UserHeroGears.Remove(userHeroGear);

            await dataContext.SaveChangesAsync();

            return userHeroGear;
        }

        public async Task<List<Models.UserHeroGear>> GetAllUserHeroGears()
        {
            return await dataContext.UserHeroGears.ToListAsync();
        }

        public async Task<Models.UserHeroGear?> GetSingleUserHeroGear(int id)
        {
            var userHeroGear = await dataContext.UserHeroGears.FindAsync(id);

            if (userHeroGear is null)
                return null;

            return userHeroGear;
        }

        public async Task<Models.UserHeroGear?> UpdateUserHeroGear(
            int id,
            Models.UserHeroGear request
        )
        {
            var userHeroGear = await dataContext.UserHeroGears.FindAsync(id);

            if (userHeroGear is null)
                return null;

            userHeroGear.GearSetId = request.GearSetId;
            userHeroGear.GearTypeId = request.GearTypeId;
            userHeroGear.Level = request.Level;
            userHeroGear.UserHeroId = request.UserHeroId;

            await dataContext.SaveChangesAsync();

            return userHeroGear;
        }
    }
}
