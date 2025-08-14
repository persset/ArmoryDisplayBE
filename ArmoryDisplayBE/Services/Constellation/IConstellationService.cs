namespace ArmoryDisplayBE.Services.Constellation
{
    public interface IConstellationService
    {
        Task<List<Models.Constellation>> GetAllConstellations();
        Task<Models.Constellation?> GetSingleConstellation(int id);
        Task<Models.Constellation> CreateConstellation(Models.Constellation constellation);
        Task<Models.Constellation?> UpdateConstellation(int id, Models.Constellation request);
        Task<Models.Constellation?> DeleteConstellation(int id);
    }
}
