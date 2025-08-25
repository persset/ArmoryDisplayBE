using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.UserSocials
{
    public class UserSocialsService : IUserSocialsService
    {
        private readonly DataContext dataContext;

        public UserSocialsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.UserSocials> CreateUserSocials(Models.UserSocials userSocials)
        {
            dataContext.UserSocials.Add(userSocials);

            await dataContext.SaveChangesAsync();

            return userSocials;
        }

        public async Task<Models.UserSocials?> DeleteUserSocials(int id)
        {
            var userSocials = await dataContext.UserSocials.FindAsync(id);

            if (userSocials is null)
                return null;

            dataContext.UserSocials.Remove(userSocials);
            await dataContext.SaveChangesAsync();

            return userSocials;
        }

        public async Task<List<Models.UserSocials>> GetAllUserSocials()
        {
            return await dataContext.UserSocials.ToListAsync();
        }

        public async Task<Models.UserSocials?> GetSingleUserSocials(int id)
        {
            var userSocials = await dataContext.UserSocials.FindAsync(id);

            if (userSocials is null)
                return null;

            return userSocials;
        }

        public async Task<Models.UserSocials?> UpdateUserSocials(int id, Models.UserSocials request)
        {
            var userSocials = await dataContext.UserSocials.FindAsync(id);

            if (userSocials is null)
                return null;

            userSocials.SocialsId = request.SocialsId;
            userSocials.Url = request.Url;
            userSocials.UserId = request.UserId;

            await dataContext.SaveChangesAsync();

            return userSocials;
        }
    }
}
