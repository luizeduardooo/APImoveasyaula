using Microsoft.AspNetCore.Mvc;
using MinhaApiBonita.Contracts.Repository;
using Moveasy.Contracts.Repository;

namespace Moveasy.Controllers
{
    [ApiController]
    [Route("city")]
    public class CityRepository : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CityRepository(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cityRepository.Get());
        }
    }
}
