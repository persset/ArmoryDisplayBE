namespace ArmoryDisplayBE.services.UserHeroGearStats
{
    public interface IUserHeroGearStats
    {
        Task<List<Models.UserHeroGearStats>> GetAllUserHeroGearStats();
        Task<Models.UserHeroGearStats?> GetSingleUserHeroGearStats(int id);
        Task<Models.UserHeroGearStats> CreateUserHeroGearStats(
            Models.UserHeroGearStats userHeroGearStats
        );
        Task<Models.UserHeroGearStats?> UpdateUserHeroGearStats(
            int id,
            Models.UserHeroGearStats request
        );
        Task<Models.UserHeroGearStats?> DeleteUserHeroGearStats(int id);
    }
}
