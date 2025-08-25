namespace ArmoryDisplayBE.Services.UserHero
{
    public interface IUserHeroService
    {
        Task<List<Models.UserHero>> GetAllUserHeroes();
        Task<Models.UserHero?> GetSingleUserHero(int id);
        Task<Models.UserHero> CreateUserHero(Models.UserHero userHero);
        Task<Models.UserHero?> UpdateUserHero(int id, Models.UserHero request);
        Task<Models.UserHero?> DeleteUserHero(int id);
    }
}
