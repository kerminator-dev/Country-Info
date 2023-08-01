using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countrySerivce;

        public CountriesController(ICountryService countrySerivce)
        {
            _countrySerivce = countrySerivce;
        }

        // GET: api/<CountriesController>
        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                var result = await _countrySerivce.GetAllAsync();

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
        public async Task<ActionResult> GetAsync([FromQuery] int countryId)
        {
            try
            {
                var result = await _countrySerivce.GetAsync(countryId);

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
        public async Task<ActionResult> GetByPhoneCode([FromQuery] int phoneCode)
        {
            try
            {
                var result = await _countrySerivce.GetByPhoneCodeAsync(phoneCode);

                return Ok(result);
            }
            catch (DataNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (WrongPhoneCodeException ex)
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
                var result = await _countrySerivce.GetCountAsync();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
