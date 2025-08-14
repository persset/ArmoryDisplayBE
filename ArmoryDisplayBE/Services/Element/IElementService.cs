namespace ArmoryDisplayBE.Services.Element
{
    public interface IElementService
    {
        Task<List<Models.Element>> GetAllElements();
        Task<Models.Element?> GetSingleElement(int id);
        Task<Models.Element> CreteElement(Models.Element element);
        Task<Models.Element?> UpdateElement(int id, Models.Element request);
        Task<Models.Element?> DeleteElement(int id);
    }
}
