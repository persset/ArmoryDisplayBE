namespace ArmoryDisplayBE.Services.Socials
{
    public interface ISocialsService
    {
        Task<List<Models.Socials>> GetAllSocialss();
        Task<Models.Socials?> GetSingleSocials(int id);
        Task<Models.Socials> CreateSocials(Models.Socials socials);
        Task<Models.Socials?> UpdateSocials(int id, Models.Socials request);
        Task<Models.Socials?> DeleteSocials(int id);
    }
}
