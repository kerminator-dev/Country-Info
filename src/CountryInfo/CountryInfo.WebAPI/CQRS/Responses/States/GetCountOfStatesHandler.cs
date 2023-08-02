using CountryInfo.WebAPI.CQRS.Queries.States;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.States
{
    public class GetCountOfStatesHandler : IRequestHandler<GetCountOfStatesQuery, int>
    {
        private readonly IStateService _stateService;

        public GetCountOfStatesHandler(IStateService stateService)
        {
            _stateService = stateService;
        }

        public async Task<int> Handle(GetCountOfStatesQuery request, CancellationToken cancellationToken)
        {
            return await _stateService.GetCountAsync();
        }
    }
}
