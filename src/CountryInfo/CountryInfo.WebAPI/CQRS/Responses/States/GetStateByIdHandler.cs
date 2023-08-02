using CountryInfo.WebAPI.CQRS.Queries.States;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.States
{
    public class GetStateByIdHandler : IRequestHandler<GetStateByIdQuery, State>
    {
        private readonly IStateService _stateService;

        public GetStateByIdHandler(IStateService stateService)
        {
            _stateService = stateService;
        }

        public async Task<State> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
        {
            return await _stateService.GetAsync(request.StateId);
        }
    }
}
