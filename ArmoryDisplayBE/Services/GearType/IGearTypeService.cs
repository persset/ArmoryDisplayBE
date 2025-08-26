namespace ArmoryDisplayBE.Services.GearType
{
    public interface IGearTypeService
    {
        Task<List<Models.GearType>> GetAllGearTypes();
        Task<Models.GearType?> GetSingleGearType(int id);
        Task<Models.GearType> CreateGearType(Models.GearType gearType);
        Task<Models.GearType?> UpdateGearType(int id, Models.GearType request);
        Task<Models.GearType?> DeleteGearType(int id);
    }
}
