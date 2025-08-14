namespace ArmoryDisplayBE.Services.Constellation
{
    public interface IConstellationService
    {
        Task<List<Models.Constellation>> GetAllConstellations();
        Task<Models.Constellation?> GetSingleConstellation(int id);
        Task<Models.Constellation> CreteConstellation(Models.Constellation constellation);
        Task<Models.Constellation?> UpdateConstellation(int id, Models.Constellation request);
        Task<Models.Constellation?> DeleteConstellation(int id);
    }
}
