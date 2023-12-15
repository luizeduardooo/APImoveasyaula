using MinhaApiBonita.Entity;

using Moveasy.Entity;
namespace Moveasy.Contracts.Repository
{
    public interface IStateRepository
    {
        Task<IEnumerable<StateEntity>> Get();
    }
}
