using Dapper;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Infrastructure;
using Moveasy.Contracts.Repository;
using Moveasy.Entity;

namespace Moveasy.Repository
{
    public class AddressRepository : Connection, IAddressRepository
    {
        public async Task<IEnumerable<AddressEntity>> Get()
        {
            string sql = "SELECT * FROM ADDRESS";
            return await GetConnection().QueryAsync<AddressEntity>(sql);
        }
    }
}
