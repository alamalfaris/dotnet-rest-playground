using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Dapper;
using Microsoft.Data.SqlClient;
using monolith_api_playground.Models;
using monolith_api_playground.Repositories;
using System.Data;
using System.Net.WebSockets;

[MemoryDiagnoser] // biar bisa lihat alokasi memori
public class StoreRepositoryBenchmarks
{
    private readonly StoreRepository _repository;

    public StoreRepositoryBenchmarks()
    {
        IDbConnection db = new SqlConnection("Server=localhost,1433;User Id=sa;Password=Adminsqlserver123!@;Database=pubs;TrustServerCertificate=true;Encrypt=false;Connection Timeout=30;");
        _repository = new StoreRepository(db);
    }

    [Benchmark]
    public async Task<List<Store>> Test_GetStoresEnum()
    {
        var result = await _repository.GetStoresEnumAsync();
        return result.ToList();
    }

    [Benchmark]
    public async Task<List<Store>> Test_GetStoresList()
    {
        var result = await _repository.GetStoresListAsync();
        return result;
    }
}