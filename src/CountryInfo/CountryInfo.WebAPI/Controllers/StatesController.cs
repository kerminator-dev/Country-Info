using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateService _stateService;

        public StatesController(IStateService stateService)
        {
            _stateService = stateService;
        }


        [HttpGet]
        public async Task<ActionResult> GetAsync([FromQuery] int stateId)
        {
            try
            {
                var result = await _stateService.GetAsync(stateId);

                return Ok(result);
            }
            catch (DataNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<ActionResult> CountAsync()
        {
            try
            {
                var result = await _stateService.GetCountAsync();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
