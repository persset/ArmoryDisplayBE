namespace ArmoryDisplayBE.Services.UserSocials
{
    public interface IUserSocialsService
    {
        Task<List<Models.UserSocials>> GetAllUserSocialss();
        Task<Models.UserSocials?> GetSingleUserSocials(int id);
        Task<Models.UserSocials> CreateUserSocials(Models.UserSocials userSocials);
        Task<Models.UserSocials?> UpdateUserSocials(int id, Models.UserSocials request);
        Task<Models.UserSocials?> DeleteUserSocials(int id);
    }
}
