using StockManagement.Interfaces;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(StockContext context) : base(context)
        {
        }
    }
}
