using monolith_api_playground.Models;

namespace monolith_api_playground.Repositories
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetStoresEnumAsync();
        Task<List<Store>> GetStoresListAsync();
    }
}
