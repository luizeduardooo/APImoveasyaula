using MinhaApiBonita.Entity;
using Moveasy.Entity;

namespace Moveasy.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();
    }
}
