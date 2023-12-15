using MinhaApiBonita.Entity;

using Moveasy.Entity;
namespace Moveasy.Contracts.Repository
{
    public interface IDistrictRepository
    {
        Task<IEnumerable<DistrictEntity>> Get();
    }
}
