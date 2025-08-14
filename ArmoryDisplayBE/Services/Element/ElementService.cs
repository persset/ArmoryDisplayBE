using ArmoryDisplayBE.Data;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Services.Element
{
    public class ElementService : IElementService
    {
        private readonly DataContext dataContext;

        public ElementService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Element> CreateElement(Models.Element element)
        {
            dataContext.Elements.Add(element);
            await dataContext.SaveChangesAsync();

            return element;
        }

        public async Task<Models.Element?> DeleteElement(int id)
        {
            var element = await dataContext.Elements.FindAsync(id);

            if (element is null)
                return null;

            dataContext.Elements.Remove(element);
            await dataContext.SaveChangesAsync();

            return element;
        }

        public async Task<List<Models.Element>> GetAllElements()
        {
            return await dataContext.Elements.ToListAsync();
        }

        public async Task<Models.Element?> GetSingleElement(int id)
        {
            var element = await dataContext.Elements.FindAsync(id);

            if (element is null)
                return null;

            return element;
        }

        public async Task<Models.Element?> UpdateElement(int id, Models.Element request)
        {
            var element = await dataContext.Elements.FindAsync(id);

            if (element is null)
                return null;

            element.Name = request.Name;

            await dataContext.SaveChangesAsync();

            return element;
        }
    }
}
