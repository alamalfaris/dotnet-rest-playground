using Dapper;
using monolith_api_playground.Models;
using System.Data;

namespace monolith_api_playground.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IDbConnection _db;
        private readonly ILogger<StoreRepository> _logger;

        public StoreRepository(IDbConnection db, ILogger<StoreRepository> logger)
        {
            _db = db;
            _logger = logger;
        }

        private static string _queryGetStores = $@"SELECT stor_id [StorId], stor_name [StorName], stor_address [StorAddress], [city], [state], [zip] FROM stores";
        
        public async Task<IEnumerable<Store>> GetStoresEnumAsync()
        {
            _logger.LogInformation("GetStoresEnumAsync start..");
            return await _db.QueryAsync<Store>(_queryGetStores);
        }

        public async Task<List<Store>> GetStoresListAsync()
        {
            var stores = await _db.QueryAsync<Store>(_queryGetStores);
            return stores.ToList();
        }
    }
}
