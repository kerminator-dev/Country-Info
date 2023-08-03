using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.States;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.States
{
    public class GetStateByIdHandler : IRequestHandler<GetStateByIdQuery, StateWithCitiesResponseDTO>
    {
        private readonly IStateService _stateService;
        private readonly IMapper _mapper;

        public GetStateByIdHandler(IStateService stateService, IMapper mapper)
        {
            _stateService = stateService;
            _mapper = mapper;
        }

        public async Task<StateWithCitiesResponseDTO> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
        {
            var state = await _stateService.GetAsync(request.StateId);

            return _mapper.Map<StateWithCitiesResponseDTO>(state);
        }
    }
}
