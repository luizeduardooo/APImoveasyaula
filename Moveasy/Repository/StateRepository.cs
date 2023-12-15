using Dapper;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Infrastructure;
using Moveasy.Contracts.Repository;
using Moveasy.Entity;

namespace Moveasy.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM STATE";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }
    }
}
