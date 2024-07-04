using StockManagement.Interfaces;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class StoreItemRepository : GenericRepository<StoreItem>, IStoreItemRepository
    {
        public StoreItemRepository(StockContext context) : base(context)
        {
        }
    }
}
