namespace ArmoryDisplayBE.Services.User
{
    public interface IUserService
    {
        Task<List<Models.User>> GetAllUsers();
        Task<Models.User?> GetSingleUser(int id);
        Task<Models.User> CreateUser(Models.User user);
        Task<Models.User?> UpdateUser(int id, Models.User request);
        Task<Models.User?> DeleteUser(int id);
    }
}
