namespace ArmoryDisplayBE.Services.GearSets;

public interface IGearSetsService
{
    Task<List<Models.GearSets>> GetAllGearSets();
    Task<Models.GearSets?> GetSingleGearSets(int id);
    Task<Models.GearSets> CreateGearSets(Models.GearSets gearSet);
    Task<Models.GearSets?> UpdateGearSets(int id, Models.GearSets request);
    Task<Models.GearSets?> DeleteGearSets(int id);
}
