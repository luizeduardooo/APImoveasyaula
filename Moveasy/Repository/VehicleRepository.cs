using Dapper;
using MinhaApiBonita.Contracts.Repository;
using MinhaApiBonita.DTO;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Infrastructure;

namespace MinhaApiBonita.Repository
{
    public class VehicleRepository : Connection, IVehicleRepository
    {
        public async Task Delete(int id)
        {
            string sql = "DELETE FROM VEHICLE WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<VehicleEntity>> Get()
        {
            string sql = "SELECT * FROM VEHICLE";
            return await GetConnection().QueryAsync<VehicleEntity>(sql);
        }

        public async Task<VehicleEntity> GetByLicensePlate(string id)
        {
            string sql = @"SELECT * 
                           FROM VEHICLE
                           WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<VehicleEntity>(sql, new { id });
        }

        public async Task Post(VehicleDTO vehicle)
        {
            string sql = @"
                INSERT INTO VEHICLE (LicensePlate, Name, Year, Capacity)
                            VALUE (@LicensePlate, @Name, @Year, @Capacity)
            ";
            await Execute(sql, vehicle);
        }

        public async Task Put(VehicleEntity vehicle)
        {
            string sql = @"
                UPDATE VEHICLE 
                SET LicensePlate = @LicensePlate,
                    Name = @Name, 
                    Year = @Year,
                    Capacity = @Capacity
                WHERE Id = @Id
            ";
            await Execute(sql, vehicle);
        }
    }
}
