using Microsoft.AspNetCore.Mvc;
using MinhaApiBonita.Contracts.Repository;
using MinhaApiBonita.Repository;
using Moveasy.Contracts.Repository;
using Moveasy.Repository;

namespace Moveasy.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressRepository : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressRepository(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _addressRepository.Get());
        }
    }
}
