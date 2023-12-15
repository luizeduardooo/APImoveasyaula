using Dapper;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Infrastructure;
using Moveasy.Contracts.Repository;
using Moveasy.Entity;

namespace Moveasy.Repository
{
    public class CityRepository : Connection, ICityRepository
    {
        public async Task<IEnumerable<CityEntity>> Get()
        {
            string sql = "SELECT * FROM CITY";
            return await GetConnection().QueryAsync<CityEntity>(sql);
        }
    }
}
