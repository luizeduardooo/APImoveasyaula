using Dapper;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Infrastructure;
using Moveasy.Contracts.Repository;
using Moveasy.Entity;

namespace Moveasy.Repository
{
    public class DistrictRepository : Connection, IDistrictRepository
    {
        public async Task<IEnumerable<DistrictEntity>> Get()
        {
            string sql = "SELECT * FROM DISTRICT";
            return await GetConnection().QueryAsync<DistrictEntity>(sql);
        }
    }
}
