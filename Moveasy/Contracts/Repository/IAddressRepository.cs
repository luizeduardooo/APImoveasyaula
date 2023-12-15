using MinhaApiBonita.Entity;
using Moveasy.Entity;

namespace Moveasy.Contracts.Repository
{
    public interface IAddressRepository
    {
        Task<IEnumerable<AddressEntity>> Get();
    }
}
