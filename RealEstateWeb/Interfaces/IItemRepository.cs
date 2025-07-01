using RealEstateWeb.Models;

namespace RealEstateWeb.Interfaces
{
    public interface IItemRepository
    {
        List<Item> FindAll();

        List<Item> FindByIdIn(IEnumerable<long> ids);
    }
}
