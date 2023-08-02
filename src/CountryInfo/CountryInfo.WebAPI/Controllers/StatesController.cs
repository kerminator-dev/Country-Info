using CountryInfo.WebAPI.CQRS.Queries.States;
using CountryInfo.WebAPI.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Controllers
{
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/States/")]
        public async Task<ActionResult> GetAsync([FromQuery] int stateId)
        {
            try
            {
                var query = new GetStateByIdQuery(stateId);

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

        [HttpGet("api/States/Count")]
        public async Task<ActionResult> CountAsync()
        {
            try
            {
                var query = new GetCountOfStatesQuery();

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
