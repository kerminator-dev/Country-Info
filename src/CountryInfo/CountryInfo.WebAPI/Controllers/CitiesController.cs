using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/Cities/{cityId}")]
        public async Task<ActionResult> GetAsync(int cityId)
        {
            try
            {
                var query = new GetCityByIdQuery(cityId);

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

        [HttpGet("api/Cities/Search={value}")]
        public async Task<ActionResult> Search( string value)
        {
            try
            {
                var query = new SearchCitiesQuery(value);

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

        [HttpGet("api/Cities/Count")]
        public async Task<ActionResult> CountAsync()
        {
            try
            {
                var query = new GetCountOfCitiesQuery();

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
