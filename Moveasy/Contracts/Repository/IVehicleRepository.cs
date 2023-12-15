using MinhaApiBonita.DTO;
using MinhaApiBonita.Entity;

namespace MinhaApiBonita.Contracts.Repository
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<VehicleEntity>> Get();
        Task Post(VehicleDTO vehicle);
        Task Put(VehicleEntity vehicle);
        Task Delete(int id);
        Task<VehicleEntity> GetByLicensePlate(string id);

    }
}
