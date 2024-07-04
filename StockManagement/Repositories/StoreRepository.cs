using StockManagement.Interfaces;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(StockContext context) : base(context)
        {
        }
    }
}
