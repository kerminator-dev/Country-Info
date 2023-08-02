using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CountryInfo.WebAPI.Extensions;

namespace CountryInfo.WebAPI.Controllers
{
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountriesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<CountriesController>
        [HttpGet("api/Countries/")]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                var query = new GetAllCountriesQuery();

                var result = await _mediator.Send(query);

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

        [HttpGet("api/Countries/{countryId}")]
        public async Task<ActionResult> GetAsync(int countryId)
        {
            try
            {
                var query = new GetCountryByIdQuery(countryId);

                var result = await _mediator.Send(query);

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

        [HttpGet("api/Countries/PhoneCode={phoneCode}")]
        public async Task<ActionResult> GetByPhoneCode(int phoneCode)
        {
            try
            {
                var query = new GetCountriesByPhoneCodeQuery(phoneCode);

                var result = await _mediator.Send(query);

                return Ok(result);
            }
            catch (DataNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (WrongPhoneCodeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("api/Countries/Count")]
        public async Task<ActionResult> CountAsync()
        {
            try
            {
                var query = new GetCountOfCountriesQuery();

                var result = await _mediator.Send(query);

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
