using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync([FromQuery] int cityId)
        {
            try
            {
                var result = await _cityService.GetAsync(cityId);

                return Ok(result);
            }
            catch (DataNotFoundException ex)
            {
                return NotFound(ex);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<ActionResult> Search([FromQuery] string cityName)
        {
            try
            {
                var result = await _cityService.Search(cityName);

                return Ok(result);
            }
            catch (DataNotFoundException ex)
            {
                return NotFound(ex);
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
                var result = await _cityService.GetCountAsync();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
