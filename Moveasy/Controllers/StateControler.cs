using Microsoft.AspNetCore.Mvc;
using Moveasy.Contracts.Repository;

namespace Moveasy.Controllers
{
    [ApiController]
    [Route("state")]
    public class StateRepository : ControllerBase
    {
        private readonly IStateRepository _stateRepository;

        public StateRepository(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _stateRepository.Get());
        }
    }
}
