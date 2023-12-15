using Microsoft.AspNetCore.Mvc;
using Moveasy.Contracts.Repository;

namespace Moveasy.Controllers
{
    [ApiController]
    [Route("district")]
    public class DistrictRepository : ControllerBase
    {
        private readonly IDistrictRepository _districtRepository;

        public DistrictRepository(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _districtRepository.Get());
        }
    }
}
