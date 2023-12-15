using Microsoft.AspNetCore.Mvc;
using MinhaApiBonita.Contracts.Repository;
using MinhaApiBonita.DTO;
using MinhaApiBonita.Entity;
using MinhaApiBonita.Repository;

namespace MinhaApiBonita.Controllers
{

    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _vehicleRepository.Delete(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _vehicleRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByLicensePlate(string id)
        {
            return Ok(await _vehicleRepository.GetByLicensePlate(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VehicleDTO vehicle)
        {
            await _vehicleRepository.Post(vehicle);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VehicleEntity vehicle)
        {
            await _vehicleRepository.Put(vehicle);
            return Ok();
        }
    }
}
