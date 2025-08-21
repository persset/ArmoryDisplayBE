using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.User
{
    public class UserService : IUserService
    {
        private readonly DataContext dataContext;

        public UserService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.User> CreateUser(Models.User user)
        {
            dataContext.Users.Add(user);

            await dataContext.SaveChangesAsync();

            return user;
        }

        public async Task<Models.User?> DeleteUser(int id)
        {
            var user = await dataContext.Users.FindAsync(id);

            if (user is null)
                return null;

            dataContext.Users.Remove(user);
            await dataContext.SaveChangesAsync();

            return user;
        }

        public async Task<List<Models.User>> GetAllUsers()
        {
            return await dataContext.Users.ToListAsync();
        }

        public async Task<Models.User?> GetSingleUser(int id)
        {
            var user = await dataContext.Users.FindAsync(id);

            if (user is null)
                return null;

            return user;
        }

        public async Task<Models.User?> UpdateUser(int id, Models.User request)
        {
            var user = await dataContext.Users.FindAsync(id);

            if (user is null)
                return null;

            user.Email = request.Email;
            user.Nickname = request.Nickname;
            user.Password = request.Password;
            user.ServerId = request.ServerId;

            await dataContext.SaveChangesAsync();

            return user;
        }
    }
}
