namespace ArmoryDisplayBE.Services.GearSet;

public interface IGearSetService
{
    Task<List<Models.GearSet>> GetAllGearSets();
    Task<Models.GearSet?> GetSingleGearSet(int id);
    Task<Models.GearSet> CreateGearSet(Models.GearSet gearSet);
    Task<Models.GearSet?> UpdateGearSet(int id, Models.GearSet request);
    Task<Models.GearSet?> DeleteGearSet(int id);
}
