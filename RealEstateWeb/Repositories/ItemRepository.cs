using RealEstateWeb.Data;
using RealEstateWeb.Interfaces;
using RealEstateWeb.Models;

namespace RealEstateWeb.Repositories
{
    public class ItemRepository(ApplicationDbContext context) : IItemRepository
    {
        private readonly ApplicationDbContext _context = context;

        public List<Item> FindAll()
        {
            return [.. _context.Items];
        }

        public List<Item> FindByIdIn(IEnumerable<long> ids)
        {
            return [.. _context.Items.Where(i => ids.Contains(i.Id))];
        }
    }
}
