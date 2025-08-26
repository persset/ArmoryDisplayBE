namespace ArmoryDisplayBE.services.UserHeroGear
{
    public interface IUserHeroGear
    {
        Task<List<Models.UserHeroGear>> GetAllUserHeroGears();
        Task<Models.UserHeroGear?> GetSingleUserHeroGear(int id);
        Task<Models.UserHeroGear> CreateUserHeroGear(Models.UserHeroGear userHeroGear);
        Task<Models.UserHeroGear?> UpdateUserHeroGear(int id, Models.UserHeroGear request);
        Task<Models.UserHeroGear?> DeleteUserHeroGear(int id);
    }
}
